import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit {

  constructor(private route: Router, private modalService: NgbModal, private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  onLogout(logoutModal) {
    this.modalService.open(logoutModal, { centered: true });
  }

  yesLogout (logoutModal) {
    this.route.navigate(['/login']);
    this.modalService.dismissAll(logoutModal);
    // this.toastr.success('Registration Successful', 'Success');
    // this.toastr.error('Registration Unsuccessful', 'Error');
  }

  cancelRegistration(cancelRegisterModal) {
    this.modalService.open(cancelRegisterModal, { centered: true });
  }

  yesCancel (cancelRegisterModal) {
    this.route.navigate(['/login']);
    this.modalService.dismissAll(cancelRegisterModal);
    // this.toastr.success('Registration Successful', 'Success');
    this.toastr.warning('Registration Cancelled', 'Warning');
  }



}