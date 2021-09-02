import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { NgbCalendar } from '@ng-bootstrap/ng-bootstrap';
import { ToastrService } from 'ngx-toastr';
import { DataService } from 'src/app/data.service';

@Component({
  selector: 'app-exhibitions',
  templateUrl: './exhibitions.component.html',
  styleUrls: ['./exhibitions.component.scss']
})
export class ExhibitionsComponent implements OnInit {

  listExhibitions: any;

  constructor(public data: DataService,private formBuilder: FormBuilder,private fb: FormBuilder, 
    private toastr: ToastrService, private router: Router,private calendar: NgbCalendar) { }

  ngOnInit(): void {

    this.data.getAllExhibitions().then((result) => { console.log(result); this.listExhibitions = result });
  }

  getExhibition(exhibition){

    this.data.sharedData = exhibition;

    this.router.navigate(['/home/exhibition']);
  
  }


}
