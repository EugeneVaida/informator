import { Component, OnInit } from '@angular/core';
import { User } from '../../shared/user.model';
import { NgForm } from '@angular/forms';
import { UserService } from '../../shared/user.service';
import { ToastrService } from 'ngx-toastr'

 
@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {
  user : User;  	
  emailPattern  = "^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$";
  roles : any[];

  constructor( private UserService: UserService, private toastr: ToastrService) { }

  ngOnInit() {
    this.resetForm();
    this.UserService.getAllRoles().subscribe(
      (data : any)=>{
        data.forEach(obj => obj.selected = false);
        this.roles = data;
      }
    );
  }

  resetForm (form? : NgForm){
    if (form != null)
      form.reset();
    this.user = {
      FirstName: '',
      LastName: '',
      UserName: '',
      Password: '',
      Email:''
    }
    if(this.roles)
      this.roles.map(x => x.selected = false);
  }

  OnSubmit(form : NgForm){
    var x = this.roles.filter(x => x.selected).map(y => y.Name);    
    this.UserService.registerUser(form.value, x).subscribe((data:any) => {
      if (data.Succeeded == true){
        this.resetForm(form);
        this.toastr.success('Successful registration');
      }
      else{
        this.toastr.error(data.Errors[0]);
      }
    });
  }


  updateSelectedRoles(index){
    this.roles[index].selected = !this.roles[index].selected;
  }
}
