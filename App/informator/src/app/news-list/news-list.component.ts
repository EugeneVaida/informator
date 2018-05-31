import { Component, OnInit } from '@angular/core';
import { NewsService } from '../shared/news.service';

@Component({
  selector: 'app-news-list',
  templateUrl: './news-list.component.html',
  styleUrls: ['./news-list.component.css']
})
export class NewsListComponent implements OnInit {

  constructor(private newsService : NewsService) { }

  ngOnInit() {
    this.newsService.getNewsList()
  }

}