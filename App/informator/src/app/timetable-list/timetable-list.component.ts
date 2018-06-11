import { Component, OnInit } from '@angular/core';
import { UserService } from '../shared/user.service';
import { TimeTableService } from '../shared/timetable.service';
import { ToastrService } from 'ngx-toastr';
import { TimeTable } from '../shared/timetable.model';

@Component({
  selector: 'app-timetable-list',
  templateUrl: './timetable-list.component.html',
  styleUrls: ['./timetable-list.component.css']
})
export class TimetableListComponent implements OnInit {

  constructor( private userService : UserService, private timeService : TimeTableService, private toastr : ToastrService) { }

  ngOnInit() {
    this.timeService.getTimeList();
  }

  showForEdit(tmt: TimeTable) {
    this.timeService.selectedTime = Object.assign({}, tmt);
  }
 
 
  onDelete(id: number) {
    if (confirm('Вы действительно хотите удалить эту запись?') == true) {
      this.timeService.deleteTime(id)
      .subscribe(x => {
        this.timeService.getTimeList();
        this.toastr.warning("Успешно удалено!","Рассписание");
      })
    }
  }

}
