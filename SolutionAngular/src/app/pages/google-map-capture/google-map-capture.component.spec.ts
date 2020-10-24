import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoogleMapCaptureComponent } from './google-map-capture.component';

describe('GoogleMapCaptureComponent', () => {
  let component: GoogleMapCaptureComponent;
  let fixture: ComponentFixture<GoogleMapCaptureComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoogleMapCaptureComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GoogleMapCaptureComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
