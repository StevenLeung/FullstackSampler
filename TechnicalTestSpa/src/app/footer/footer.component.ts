import { Component, OnInit } from '@angular/core';
import { ConfiguredUrlsService } from '../_services/configured-urls.service';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent implements OnInit {

  gitHubUrl = '';

  constructor(private configuredUrls: ConfiguredUrlsService) { }

  ngOnInit(): void {
    this.gitHubUrl = this.configuredUrls.gitHubUrl;
  }

}
