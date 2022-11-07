import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderModule } from './header/header.module';
import { LoaderComponent } from './loader/loader.component';
import { TranslateModule } from '@ngx-translate/core';
import { ErrorComponent } from './error/error.component';
import { FooterModule } from './footer/footer.module';

@NgModule({
  declarations: [LoaderComponent, ErrorComponent],
  imports: [CommonModule, HeaderModule, FooterModule, TranslateModule],
  exports: [HeaderModule, LoaderComponent, FooterModule],
})
export class WidgetModule {}
