import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './_header/header.component';
import { NavListComponent } from './nav-list/nav-list.component';
import { TopNavComponent } from './top-nav/top-nav.component';
import { NavBottomComponent } from './nav-bottom/nav-bottom.component';
import { TitleHeaderComponent } from './title-header/title-header.component';


@NgModule({
  declarations: [
    HeaderComponent,
    NavListComponent,
    TopNavComponent,
    NavBottomComponent,
    TitleHeaderComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [HeaderComponent]
})
export class HeaderModule { }
