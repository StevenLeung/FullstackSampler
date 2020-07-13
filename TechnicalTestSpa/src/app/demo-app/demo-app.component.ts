import { Component, OnInit } from '@angular/core';
import { FindMatchesService } from '../_services/find-matches-service';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { FindMatchesInput } from '../_models/find-matches-input';

@Component({
  selector: 'app-demo-app',
  templateUrl: './demo-app.component.html',
  styleUrls: ['./demo-app.component.css']
})
export class DemoAppComponent implements OnInit {
  matchesForm: FormGroup;
  model: FindMatchesInput;
  indexes: [];
  wasAttempted: boolean = false;

  constructor(private findMatchesService: FindMatchesService, private fb: FormBuilder) { }

  ngOnInit(): void {
    this.setDefaults();
    this.createForm();
  }

  setDefaults() {
    this.model = Object.assign({}, { text: 'abra ka dabra', subtext: 'abra' });
  }

  createForm() {
    this.matchesForm = this.fb.group({
      text: [this.model.text, Validators.required],
      subtext: [this.model.subtext, Validators.required]
    },
      { validator: this.textboxesValidator })
  }

  textboxesValidator(g: FormGroup) {
    return g.get('text').value?.length >= g.get('subtext').value?.length ? null : { 'smaller': true };
  }

  submit() {
    if (this.matchesForm.valid) {
      this.model = Object.assign({}, this.matchesForm.value);

      this.findMatchesService.findMatches(this.model).subscribe(response => {
        this.indexes = response.characterPositions;
      }, error => {
        console.log(error);
      });
      this.wasAttempted = true;
    }
  }

  tryAgain() {
    this.setDefaults()
    this.matchesForm.reset(this.model);
    this.wasAttempted = false;
  }

}
