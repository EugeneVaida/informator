import { Component, OnInit } from '@angular/core';
import { TimeTableService } from '../shared/timetable.service'; 

@Component({
  selector: 'app-today-time-table',
  templateUrl: './today-time-table.component.html',
  styleUrls: ['./today-time-table.component.css']
})
export class TodayTimeTableComponent implements OnInit {

  constructor(private timeService : TimeTableService) { }

  ngOnInit() {
    this.timeService.getTodayTimeList();
  }

}
