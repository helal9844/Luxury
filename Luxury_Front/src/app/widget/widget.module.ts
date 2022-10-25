import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FooterComponent } from './footer/footer.component';
import { HeaderModule } from './header/header.module';
import { LoaderComponent } from './loader/loader.component';

@NgModule({
  declarations: [
    FooterComponent,
    LoaderComponent
  ],
  imports: [
    CommonModule,
    HeaderModule
  ],
  exports: [HeaderModule,FooterComponent, LoaderComponent]
})
export class WidgetModule { }
