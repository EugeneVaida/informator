import { Injectable } from '@angular/core';
import { Http, HttpModule, Response, Headers, RequestOptions, RequestMethod } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';
import { News } from './news.model';

@Injectable()
export class NewsService {
  selectedNews : News;
  newsList : News[];
  constructor(private http : Http) { }

  postNews(nws : News){
    var body = JSON.stringify(nws);
    var headerOptions = new Headers({'Content-Type':'application/json'});
    var requestOptions = new RequestOptions({method : RequestMethod.Post,headers : headerOptions});
    return this.http.post('http://localhost:6936/api/News',body,requestOptions).map(x => x.json());
  }
 
  putNews(id, nws) {
    var body = JSON.stringify(nws);
    var headerOptions = new Headers({ 'Content-Type': 'application/json' });
    var requestOptions = new RequestOptions({ method: RequestMethod.Put, headers: headerOptions });
    return this.http.put('http://localhost:6936/api/News/' + id,
      body,
      requestOptions).map(res => res.json());
  }
 
  getNewsList(){
    this.http.get('http://localhost:6936/api/News')
    .map((data : Response) =>{
      return data.json() as News[];
    }).toPromise().then(x => {
      this.newsList =  x;
    })
  }
 
  deleteNews(id: number) {
    return this.http.delete('http://localhost:6936/api/News/' + id).map(res => res.json());
  }


}
