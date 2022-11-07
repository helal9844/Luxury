import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FooterComponent } from './footer/footer.component';
import { HeaderModule } from './header/header.module';
import { LoaderComponent } from './loader/loader.component';
import { BottomFooterComponent } from './bottom-footer/bottom-footer.component';
import { TranslateModule } from '@ngx-translate/core';
import { ErrorComponent } from './error/error.component';
@NgModule({
  declarations: [FooterComponent, LoaderComponent, BottomFooterComponent, ErrorComponent],
  imports: [CommonModule, HeaderModule, TranslateModule],
  exports: [
    HeaderModule,
    FooterComponent,
    LoaderComponent,
    BottomFooterComponent,
  ],
})
export class WidgetModule {}
