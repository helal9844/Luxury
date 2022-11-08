import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AboutComponent } from './about/about.component';
import { TranslateModule, TranslateLoader } from '@ngx-translate/core';
import { HttpClient } from '@angular/common/http';
import { TranslateHttpLoader } from '@ngx-translate/http-loader';
import { HttpClientModule } from '@angular/common/http';
import { TranslateService } from '@ngx-translate/core';
import { MainHomeComponent } from './home/main-home/main-home.component';
import { StatesComponent } from './home/states/states.component';
import { CarouselModule } from 'ngx-owl-carousel-o';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [MainHomeComponent, AboutComponent, StatesComponent],
  imports: [
    CommonModule,
    HttpClientModule,
    TranslateModule.forRoot({
      defaultLanguage: 'en',
      loader: {
        provide: TranslateLoader,
        useFactory: HttpTransLoader,
        deps: [HttpClient],
      },
    }),
    CarouselModule,
    BrowserAnimationsModule,
  ],
})
export class PagesModule {
  // currentLang: string;

  constructor(public translate: TranslateService) {
    // translate.setDefaultLang('en');
    // translate.use('ar');
  }

  changeCurrentLang(lang: string) {
    this.translate.use(lang);
    localStorage.setItem('currentLnag', lang);
  }
}
export function HttpTransLoader(http: HttpClient) {
  return new TranslateHttpLoader(http, '../assets/langs/', '.json');
}
