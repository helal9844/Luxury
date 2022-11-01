import { Component, OnInit } from '@angular/core';
import { TranslateService } from "@ngx-translate/core";
@Component({
  selector: 'top-nav',
  templateUrl: './top-nav.component.html',
  styleUrls: ['./top-nav.component.scss']
})
export class TopNavComponent implements OnInit {

  public currentLang: string;
  public checkLang: string;
  public src: string;
  public currentSrc: string;
  constructor(public translate: TranslateService) {
    this.currentLang = localStorage.getItem('currentLang') || 'ar';
    this.translate.use(this.currentLang);
    this.checkLang = this.currentLang == 'ar'? 'en': 'ar';
    this.src = this.chnageLangImg(this.checkLang);
    this.currentSrc = this.chnageLangImg(this.currentLang);
    document.body.dir = this.currentLang == 'ar'? 'rtl': 'ltr';
  }

  changeCurrentLang(lang:string){
    this.translate.use(lang);
    localStorage.setItem('currentLang', lang);
    this.checkLang = lang == 'ar'? 'en': 'ar';
    this.src = this.chnageLangImg(this.checkLang);
    this.currentSrc = this.chnageLangImg(lang);
    document.body.dir = lang == 'ar'? 'rtl': 'ltr';
  }

  chnageLangImg(lang:string):string {
    return `assets/images/${lang}.png`
  }



  ngOnInit(): void {
    this.translate.onLangChange.subscribe(()=>{
      
    });
  }

}
