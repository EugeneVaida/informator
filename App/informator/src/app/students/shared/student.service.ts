import { Injectable } from '@angular/core';
import { AngularFireDatabase, AngularFireList } from 'angularfire2/database';
import { Student } from './student.model';

@Injectable()
export class StudentService {
  studentList : AngularFireList<any>;
  selectedStudent : Student = new Student();
  constructor(private firebae : AngularFireDatabase ) { }

  getData(){
    this.studentList = this.firebae.list('students');
    return this.studentList;
  }

  insertStudent(student : Student){
    this.studentList.push({
      name : student.name,
      surname : student.surname,
      age : student.age,
      group : student.group
    });
  }

  updateStudent(student : Student){
    this.studentList.update(student.$key, {
      name : student.name,
      surname : student.surname,
      age : student.age,
      group : student.group
    });
  }

  deleteStudent($key : string){
    this.studentList.remove($key);
  }
}
