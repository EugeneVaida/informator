import { Component, OnInit } from '@angular/core';
import { TimeTableService } from '../shared/timetable.service';
import { ToastrService } from 'ngx-toastr';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-timetable',
  templateUrl: './timetable.component.html',
  styleUrls: ['./timetable.component.css']
})
export class TimetableComponent implements OnInit {

  constructor(private timeService : TimeTableService, private toastr : ToastrService ) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form? : NgForm){
    if (form != null){
      form.reset();
    }
    this.timeService.selectedTime = {
      Id : null,
      Room : '',
      Subject: '',
      Group: '',
      Date: ''
    }
  }

  onSubmit(form : NgForm){
    if (form.value.Id == null){
      this.timeService.postTime(form.value).subscribe( data => { 
        this.resetForm(form);
        this.timeService.getTimeList();
        this.toastr.success('Рассписание добавлено','Рассписание');
      })
    }
    else
    {
      this.timeService.putTime(form.value.Id,form.value).subscribe( data => {
        this.resetForm(form);
        this.timeService.getTimeList();
        this.toastr.success('Рассписание обновлено','Рассписание');
      })
    }
  }

}
