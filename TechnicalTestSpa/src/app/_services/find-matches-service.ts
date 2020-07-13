import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { ConfiguredUrlsService } from './configured-urls.service';
import { FindMatchesInput } from '../_models/find-matches-input';
import { FindMatchesResult } from '../_models/find-matches-result';

@Injectable({
  providedIn: 'root'
})
export class FindMatchesService {
  ;

  constructor(private http: HttpClient, private configuredUrls: ConfiguredUrlsService) { }

  findMatches(input: FindMatchesInput) : Observable<FindMatchesResult> {
    var baseUrl = this.configuredUrls.baseUrl;
    return this.http.post<FindMatchesResult>(baseUrl + 'matches/find', input);
  }

}
