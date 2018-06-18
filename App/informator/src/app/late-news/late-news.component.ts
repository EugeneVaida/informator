import { Component, OnInit } from '@angular/core';
import { NewsService } from '../shared/news.service';

@Component({
  selector: 'app-late-news',
  templateUrl: './late-news.component.html',
  styleUrls: ['./late-news.component.css'],
  providers :[NewsService]
})
export class LateNewsComponent implements OnInit {

  constructor(private newsService : NewsService) { }

  ngOnInit() {
    this.newsService.getNewsList();
  }

}
