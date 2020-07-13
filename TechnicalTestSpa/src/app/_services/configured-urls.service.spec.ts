import { TestBed } from '@angular/core/testing';

import { ConfiguredUrlsService } from './configured-urls.service';

describe('ConfiguredUrlsService', () => {
  let service: ConfiguredUrlsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ConfiguredUrlsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
