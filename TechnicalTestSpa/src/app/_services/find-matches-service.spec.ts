import { TestBed } from '@angular/core/testing';

import { FindMatchesServiceService } from './find-matches-service.service';

describe('FindMatchesServiceService', () => {
  let service: FindMatchesServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FindMatchesServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
