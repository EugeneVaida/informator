import { Component, OnInit } from '@angular/core';
import { NewsService } from '../shared/news.service';
import { ToastrService } from 'ngx-toastr';
import { NgForm } from '@angular/forms';


@Component({
  selector: 'app-news',
  templateUrl: './news.component.html',
  styleUrls: ['./news.component.css']
})
export class NewsComponent implements OnInit {

  constructor(private newsService : NewsService, private toastr : ToastrService) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form? : NgForm){
    if (form != null){
      form.reset();
    }
    this.newsService.selectedNews = {
      ID : null,
      NewsName: '',
      Text: '',
      Description: '',
      Date: ''
    }
  }

  onSubmit(form : NgForm){
    if (form.value.ID == null){
      this.newsService.postNews(form.value).subscribe( data => { 
        this.resetForm();
        this.newsService.getNewsList();
        this.toastr.success('News added','News add');
      })
    }
    else
    {
      this.newsService.putNews(form.value.ID,form.value).subscribe( data => {
        this.resetForm();
        this.newsService.getNewsList();
        this.toastr.success('News added updated','News add');
      })
    }
  }
}
