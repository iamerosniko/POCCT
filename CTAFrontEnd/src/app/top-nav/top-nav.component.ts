import { Component, OnInit } from '@angular/core';
// import { AppSignIn, AppToken, BtamEntity, UserAppRole } from '../../../entities/btam';
import { BtamserviceService } from '../services/btamservice.service';
import { Router } from '@angular/router';
import { UUser,UServices,UAttributes } from '../entities';

@Component({
  selector: 'top-nav',
  templateUrl: './top-nav.component.html',
  styleUrls: ['./top-nav.component.css']
})
export class TopNavComponent {
  public MyName:string="";
  public user:UUser;
  public URoutes:UAttributes[];
  //implements OnInit {
  // public currentUser:UserAppRole={ Role:''};

  constructor(private loginSvc : BtamserviceService,private router: Router){}

  async ngOnInit(){
    this.user=await this.loginSvc.logIn();
    this.MyName = await this.user.FirstName;
    var service = this.user.Services.find(x=>x.ServiceName=="Routes")
    this.URoutes = service.Attributes;
  }

  async goTo(path: string){
    this.router.navigate([path]);
  }
}
