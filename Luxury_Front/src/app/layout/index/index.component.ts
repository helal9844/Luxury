import { Component, OnInit } from '@angular/core';
import { GlobalConstants } from 'src/app/Helpers/global-constants';
@Component({
  selector: 'app-root',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.scss']
})
export class IndexComponent implements OnInit {

  loader = GlobalConstants.loader;

  constructor() { }

  ngOnInit(): void {
  }

}
