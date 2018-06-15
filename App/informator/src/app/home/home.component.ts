import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from '../shared/user.service';
import { NewsService } from '../shared/news.service';
import { TimeTableService } from '../shared/timetable.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
  providers :[NewsService, TimeTableService]
})
export class HomeComponent implements OnInit {
  userClaims: any;

  constructor(private router: Router, private timeService : TimeTableService, private userService: UserService, private newsService : NewsService) { }

  ngOnInit() {
    this.userService.getUserClaims().subscribe((data: any) => {
      this.userClaims = data;

    });
  }

  Logout() {
    localStorage.removeItem('userToken');
    this.router.navigate(['/login']);
  }


}
