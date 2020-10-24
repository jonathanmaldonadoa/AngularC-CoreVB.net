import { TestBed } from '@angular/core/testing';

import { GoogleMapCaptureService } from './google-map-capture.service';

describe('GoogleMapCaptureService', () => {
  let service: GoogleMapCaptureService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GoogleMapCaptureService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
