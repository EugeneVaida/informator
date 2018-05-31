import { Component, OnInit } from '@angular/core';
import { NewsService } from '../shared/news.service';

@Component({
  selector: 'app-admin-panel',
  templateUrl: './admin-panel.component.html',
  styleUrls: ['./admin-panel.component.css'],
  providers :[NewsService]
})
export class AdminPanelComponent implements OnInit {

  constructor( private newsService : NewsService ) { }

  ngOnInit() {
  }

}
