import { Component, OnInit } from '@angular/core';
import { ConfiguredUrlsService } from '../_services/configured-urls.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  linkedInUrl = '';
  certificationsUrl = '';

  constructor(private configuredUrl : ConfiguredUrlsService) { }

  ngOnInit(): void {
    this.linkedInUrl = this.configuredUrl.linkedInUrl;
    this.certificationsUrl = this.configuredUrl.certificationsUrl;
  }

}
