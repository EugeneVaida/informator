import { Component, OnInit } from '@angular/core';
import { NewsService } from '../shared/news.service';
import { TimeTableService } from '../shared/timetable.service';

@Component({
  selector: 'app-admin-panel',
  templateUrl: './admin-panel.component.html',
  styleUrls: ['./admin-panel.component.css'],
  providers :[NewsService , TimeTableService]
})
export class AdminPanelComponent implements OnInit {

  constructor( private newsService : NewsService, private timeService : TimeTableService ) { }

  ngOnInit() {
  }

}
