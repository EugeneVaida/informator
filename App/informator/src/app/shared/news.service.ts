import { Injectable } from '@angular/core';
import { News } from './news.model';
import { Http } from '@angular/http';

@Injectable()
export class NewsService {
  selectedNews : News;
  newsList : News[];
  constructor(private http : Http) { }



}
