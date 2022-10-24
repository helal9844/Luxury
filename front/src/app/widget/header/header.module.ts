import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './_header/header.component';
import { NavListComponent } from './nav-list/nav-list.component';
import { TopNavComponent } from './top-nav/top-nav.component';


@NgModule({
  declarations: [
    HeaderComponent,
    NavListComponent,
    TopNavComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [HeaderComponent]
})
export class HeaderModule { }
