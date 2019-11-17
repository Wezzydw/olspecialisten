import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BeerUpdateComponent } from './beer-update.component';

describe('BeerUpdateComponent', () => {
  let component: BeerUpdateComponent;
  let fixture: ComponentFixture<BeerUpdateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BeerUpdateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BeerUpdateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
