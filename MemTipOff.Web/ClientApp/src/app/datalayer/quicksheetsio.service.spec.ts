import { TestBed, inject } from '@angular/core/testing';

import { QuicksheetsioService } from './quicksheetsio.service';

describe('QuicksheetsioService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [QuicksheetsioService]
    });
  });

  it('should be created', inject([QuicksheetsioService], (service: QuicksheetsioService) => {
    expect(service).toBeTruthy();
  }));
});
