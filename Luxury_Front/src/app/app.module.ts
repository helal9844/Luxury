import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { IndexComponent } from './layout/index/index.component';
import { WidgetModule } from './widget/widget.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { PagesModule } from './pages/pages.module';

@NgModule({
  declarations: [IndexComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,
    PagesModule,
    WidgetModule,
    NgbModule,
  ],
  providers: [],
  bootstrap: [IndexComponent],
})
export class AppModule {}
