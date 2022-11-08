import { Component, OnInit } from '@angular/core';
import { OwlOptions } from 'ngx-owl-carousel-o';
@Component({
  selector: 'states',
  templateUrl: './states.component.html',
  styleUrls: ['./states.component.scss'],
})
export class StatesComponent implements OnInit {
  // htext = [
  //   { value: 'Dahab1' },
  //   { value: 'Dahab2' },
  //   { value: 'Dahab3' },
  //   { value: 'Dahab4' },
  //   { value: 'Dahab5' },
  // ];
  // slides = [
  //   {
  //     img: 'https://cf.bstatic.com/xdata/images/city/square250/644433.jpg?k=89cfcf202975aed2abbc6e79faf2306142982cf3731e63c006b0226016220e4b&o=',
  //   },
  //   {
  //     img: 'https://cf.bstatic.com/xdata/images/city/square250/644433.jpg?k=89cfcf202975aed2abbc6e79faf2306142982cf3731e63c006b0226016220e4b&o=',
  //   },
  //   {
  //     img: 'https://cf.bstatic.com/xdata/images/city/square250/644433.jpg?k=89cfcf202975aed2abbc6e79faf2306142982cf3731e63c006b0226016220e4b&o=',
  //   },
  //   {
  //     img: 'https://cf.bstatic.com/xdata/images/city/square250/644433.jpg?k=89cfcf202975aed2abbc6e79faf2306142982cf3731e63c006b0226016220e4b&o=',
  //   },
  //   {
  //     img: 'https://cf.bstatic.com/xdata/images/city/square250/644433.jpg?k=89cfcf202975aed2abbc6e79faf2306142982cf3731e63c006b0226016220e4b&o=',
  //   },
  // ];
  // slideConfig = { slidesToShow: 5, slidesToScroll: 1 };
  // addSlide() {
  //   this.slides.push({ img: 'http://placehold.it/350x150/777777' });
  // }
  // removeSlide() {
  //   this.slides.length = this.slides.length - 1;
  // }
  // slickInit(e: any) {
  //   console.log('slick initialized');
  // }
  // breakpoint(e: any) {
  //   console.log('breakpoint');
  // }
  // afterChange(e: any) {
  //   console.log('afterChange');
  // }
  // beforeChange(e: any) {
  //   console.log('beforeChange');
  // }
  ///////////////////////////////////////////////
  customOptions: OwlOptions = {
    loop: true,
    mouseDrag: true,
    touchDrag: true,
    pullDrag: false,
    dots: false,
    margin: 10,
    navSpeed: 700,
    navText: ['', ''],
    responsive: {
      0: {
        items: 1,
      },
      400: {
        items: 2,
      },
      740: {
        items: 3,
      },
      940: {
        items: 5,
      },
    },
    nav: true,
  };
  slides = [
    {
      img: 'https://cf.bstatic.com/xdata/images/city/square250/644365.webp?k=8ad39e2f63737e18f4a59e215d940d628838352c53e1069c8366893d9521d8e6&o=',
    },
    {
      img: 'https://cf.bstatic.com/xdata/images/city/square250/644433.jpg?k=89cfcf202975aed2abbc6e79faf2306142982cf3731e63c006b0226016220e4b&o=',
    },
    {
      img: 'https://cf.bstatic.com/xdata/images/city/square250/644630.webp?k=700ac1d32a3bab480b14db2cba3050abe5b5bce062911dc4f5b3fdc15d81f007&o=',
    },
    {
      img: 'https://cf.bstatic.com/xdata/images/city/square250/644433.jpg?k=89cfcf202975aed2abbc6e79faf2306142982cf3731e63c006b0226016220e4b&o=',
    },
    {
      img: 'https://cf.bstatic.com/xdata/images/city/square250/644433.jpg?k=89cfcf202975aed2abbc6e79faf2306142982cf3731e63c006b0226016220e4b&o=',
    },
    {
      img: 'https://cf.bstatic.com/xdata/images/city/square250/644433.jpg?k=89cfcf202975aed2abbc6e79faf2306142982cf3731e63c006b0226016220e4b&o=',
    },
    {
      img: 'https://cf.bstatic.com/xdata/images/city/square250/644433.jpg?k=89cfcf202975aed2abbc6e79faf2306142982cf3731e63c006b0226016220e4b&o=',
    },
    {
      img: 'https://cf.bstatic.com/xdata/images/city/square250/644433.jpg?k=89cfcf202975aed2abbc6e79faf2306142982cf3731e63c006b0226016220e4b&o=',
    },
    {
      img: 'https://cf.bstatic.com/xdata/images/city/square250/644433.jpg?k=89cfcf202975aed2abbc6e79faf2306142982cf3731e63c006b0226016220e4b&o=',
    },
  ];
  constructor() {}

  ngOnInit(): void {}
}
