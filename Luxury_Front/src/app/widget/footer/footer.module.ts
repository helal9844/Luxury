import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FooterComponent } from './footer/footer.component';
import { BottomFooterComponent } from './bottom-footer/bottom-footer.component';
import { TopFooterComponent } from './top-footer/top-footer.component';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
  declarations: [FooterComponent, TopFooterComponent, BottomFooterComponent],
  imports: [CommonModule, TranslateModule],
  exports: [FooterComponent],
})
export class FooterModule {}
