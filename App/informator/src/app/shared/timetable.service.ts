import { Injectable } from '@angular/core';
import { Http, HttpModule, Response, Headers, RequestOptions, RequestMethod } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';
import { TimeTable } from './timetable.model';
import { HttpHeaders } from '@angular/common/http';

@Injectable()
export class TimeTableService {
  selectedTime : TimeTable;
  timeList : TimeTable[];
  constructor(private http : Http) { }



  postTime(tmt : TimeTable){
    var body = JSON.stringify(tmt);
    var headerOptions = new Headers({ 'Content-Type': 'application/json' });
    headerOptions.append('Authorization', `Bearer ${localStorage.getItem('userToken')}`);
    //var header = new HttpHeaders({"Authorization" : "Bearer " + localStorage.getItem('userToken')});
    var requestOptions = new RequestOptions({ method: RequestMethod.Post, headers: headerOptions });
    return this.http.post('http://localhost:6936/api/TimeTables', body, requestOptions).map(x => x.json());
  }
  
 
  putTime(id, tmt) {
    var body = JSON.stringify(tmt);
    var headerOptions = new Headers({ 'Content-Type': 'application/json', "Authorization" : "Bearer " + localStorage.getItem('userToken') });
    var requestOptions = new RequestOptions({ method: RequestMethod.Put, headers: headerOptions });
    return this.http.put('http://localhost:6936/api/TimeTables/' + id, body, requestOptions).map(res => res.json());
  }
 
  getTimeList(){
    this.http.get('http://localhost:6936/api/TimeTables')
    .map((data : Response) =>{
      return data.json() as TimeTable[];
    }).toPromise().then(x => {
      this.timeList =  x;
    })
  }

  getTodayTimeList(){
    this.http.get('http://localhost:6936/api/GetTodayTimeTable')
    .map((data : Response) =>{
      return data.json() as TimeTable[];
    }).toPromise().then(x => {
      this.timeList =  x;
    })
  }
 
  deleteTime(id: number) {
    var headerOptions = new Headers({ 'Content-Type': 'application/json', "Authorization" : "Bearer " + localStorage.getItem('userToken') });    
    //var header = new HttpHeaders({"Authorization" : "Bearer " + localStorage.getItem('userToken')});
    var requestOptions = new RequestOptions({ method: RequestMethod.Delete, headers: headerOptions });
    return this.http.delete('http://localhost:6936/api/TimeTables/' + id, requestOptions).map(res => res.json());
  }


}
