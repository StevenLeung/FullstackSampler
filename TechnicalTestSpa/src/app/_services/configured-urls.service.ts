import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ConfiguredUrlsService {
  baseUrl = environment.apiUrl;
  certificationsUrl = environment.certificationsUrl;
  linkedInUrl = environment.linkedInUrl;
  gitHubUrl = environment.gitHubUrl;

  constructor() { }
}
