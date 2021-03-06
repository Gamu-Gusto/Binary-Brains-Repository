import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { ToastrModule } from 'ngx-toastr';
import { HomeComponent } from './home/home.component';
import { NavbarComponent } from './home/navbar/navbar.component';
import { MDBBootstrapModule } from 'angular-bootstrap-md';
import { MdbModule } from 'mdb-angular-ui-kit';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ArtClassesComponent } from './home/art-classes/art-classes.component';
import { ArtClassComponent } from './home/art-class/art-class.component';
import { MyBookingsComponent } from './home/my-bookings/my-bookings.component';
import { BookingsComponent } from './home/my-bookings/bookings/bookings.component';
import { RefundsComponent } from './home/my-bookings/refunds/refunds.component';
import { CompletedClassComponent } from './home/my-bookings/completed-class/completed-class.component';
import { FeedbackComponent } from './home/my-bookings/feedback/feedback.component';
import { ResetPasswordComponent } from './reset-password/reset-password.component';
import { NewPasswordComponent } from './new-password/new-password.component';
import { ArtistHomeComponent } from './artist-home/artist-home.component';
import { ArtistNavbarComponent } from './artist-home/artist-navbar/artist-navbar.component';
import { MyExhibitionsComponent } from './artist-home/my-exhibitions/my-exhibitions.component';
import { ArtistExhibitionsComponent } from './artist-home/artist-exhibitions/artist-exhibitions.component';
import { ArtistExhibitionComponent } from './artist-home/artist-exhibition/artist-exhibition.component';
import { ArtistBookingsComponent } from './artist-home/artist-bookings/artist-bookings.component';
import { ClassComponent } from './artist-home/class/class.component';
import { ClassesComponent } from './artist-home/classes/classes.component';
import { ArtistbookingComponent } from './artist-home/artist-bookings/artistbooking/artistbooking.component';
import { ArtistRefundsComponent } from './artist-home/artist-bookings/artist-refunds/artist-refunds.component';
import { ArtistCompletedComponent } from './artist-home/artist-bookings/artist-completed/artist-completed.component';
import { ArtistFeedbackComponent } from './artist-home/artist-bookings/artist-feedback/artist-feedback.component';
import { ExhibitionsComponent } from './home/exhibitions/exhibitions.component';
import { ExhibitionComponent } from './home/exhibition/exhibition.component';
import { UserAccountComponent } from './home/user-account/user-account.component';
import { ArtistAccountComponent } from './artist-home/artist-account/artist-account.component';
import { InvitationsComponent } from './artist-home/invitations/invitations.component';
import { ApplyExhibitionComponent } from './artist-home/apply-exhibition/apply-exhibition.component';
import { MyArtworkComponent } from './artist-home/my-artwork/my-artwork.component';
import { ArtistShowroomComponent } from './artist-home/artist-showroom/artist-showroom.component';
import { ArtworkShowroomComponent } from './home/artwork-showroom/artwork-showroom.component';
import { AnnouncementsComponent } from './home/announcements/announcements.component';
import { RegisterArtistComponent } from './register-artist/register-artist.component';
import { AcceptedExhibitionsComponent } from './artist-home/my-exhibitions/accepted-exhibitions/accepted-exhibitions.component';
import { ApplicationsComponent } from './artist-home/my-exhibitions/applications/applications.component';
import { GenerateTagsComponent } from './artist-home/my-exhibitions/generate-tags/generate-tags.component';
import { ContactUserComponent } from './home/contact-user/contact-user.component';
import { ContactArtistComponent } from './artist-home/contact-artist/contact-artist.component';
import { ArtistAnnouncementComponent } from './artist-home/artist-announcement/artist-announcement.component';


@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    HomeComponent,
    NavbarComponent,
    ArtClassesComponent,
    ArtClassComponent,
    MyBookingsComponent,
    BookingsComponent,
    RefundsComponent,
    CompletedClassComponent,
    FeedbackComponent,
    ResetPasswordComponent,
    NewPasswordComponent,
    ArtistHomeComponent,
    ArtistNavbarComponent,
    MyExhibitionsComponent,
    ArtistExhibitionsComponent,
    ArtistExhibitionComponent,
    ArtistBookingsComponent,
    ClassComponent,
    ClassesComponent,
    ArtistbookingComponent,
    ArtistRefundsComponent,
    ArtistCompletedComponent,
    ArtistFeedbackComponent,
    ExhibitionsComponent,
    ExhibitionComponent,
    UserAccountComponent,
    ArtistAccountComponent,
    InvitationsComponent,
    ApplyExhibitionComponent,
    MyArtworkComponent,
    ArtistShowroomComponent,
    ArtworkShowroomComponent,
    AnnouncementsComponent,
    RegisterArtistComponent,
    AcceptedExhibitionsComponent,
    ApplicationsComponent,
    GenerateTagsComponent,
    ContactUserComponent,
    ContactArtistComponent,
    ArtistAnnouncementComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    ToastrModule.forRoot(),
    MDBBootstrapModule.forRoot(),
    MdbModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
