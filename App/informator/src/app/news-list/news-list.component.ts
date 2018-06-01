import { Component, OnInit } from '@angular/core';
import { NewsService } from '../shared/news.service';
import { News } from '../shared/news.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-news-list',
  templateUrl: './news-list.component.html',
  styleUrls: ['./news-list.component.css']
})
export class NewsListComponent implements OnInit {

  constructor(private newsService : NewsService, private toastr : ToastrService) { }

  ngOnInit() {
    this.newsService.getNewsList()
  }

  showForEdit(nws: News) {
    this.newsService.selectedNews = Object.assign({}, nws);;
  }
 
 
  onDelete(id: number) {
    if (confirm('Are you sure to delete this record ?') == true) {
      this.newsService.deleteNews(id)
      .subscribe(x => {
        this.newsService.getNewsList();
        this.toastr.warning("Deleted Successfully","Employee Register");
      })
    }
  }

}
