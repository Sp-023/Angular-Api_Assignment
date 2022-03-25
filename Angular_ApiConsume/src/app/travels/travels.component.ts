import { Component, OnInit } from '@angular/core';
import { FormBuilder,FormGroup } from '@angular/forms';
import { ApiService } from '../api.service';
import { TravelModel } from './travel.model';

@Component({
  selector: 'app-travels',
  templateUrl: './travels.component.html',
  styleUrls: ['./travels.component.css']
})
export class TravelsComponent implements OnInit {
  formvalue!:FormGroup;
  Travelobj:TravelModel = new TravelModel();
  traveldata!:any;
  showadd!:boolean;
  showupdate!:boolean;


  constructor(private formbuilder:FormBuilder, private api:ApiService) { }

  ngOnInit(): void {
    this.formvalue=this.formbuilder.group({
      firstname:[''],
      lastname:[''],
      gender:[''],
      phoneno:[''],
      travelFrom:[''],
      travelTo:['']

    })
    this.getTravelsdetails();
  }

  addtravels()
  {
    this.formvalue.reset();
    this.showadd=true;
    this.showupdate=false;
  }
  posttraveldetails()
  {
    this.Travelobj.firstname=this.formvalue.value.firstname;
    this.Travelobj.lastname=this.formvalue.value.lastname;
    this.Travelobj.gender=this.formvalue.value.gender;
    this.Travelobj.phoneno=this.formvalue.value.phoneno;
    this.Travelobj.travelFrom=this.formvalue.value.travelFrom;
    this.Travelobj.travelTo=this.formvalue.value.travelTo;

    this.api.postTravels(this.Travelobj)
    .subscribe(res=>{
      console.log(res);
      alert("record successfuly added");
      this.getTravelsdetails();
      let ref=document.getElementById('cancel')
      ref?.click();
      this.formvalue.reset();
    },
    err=>{
      alert("something went wrong");
      let ref=document.getElementById('cancel')
      ref?.click();
    })
  }

getTravelsdetails()
{
  this.api.getTravels()
  .subscribe(res=>{
    this.traveldata=res;
  })
}

OnEdit(tt:any)
{
  this.showadd=false;
  this.showupdate=true;
this.Travelobj.id=tt.id;
this.formvalue.controls['firstname'].setValue(tt.firstname);
this.formvalue.controls['lastname'].setValue(tt.lastname);
this.formvalue.controls['gender'].setValue(tt.gender);
this.formvalue.controls['phoneno'].setValue(tt.phoneno);
this.formvalue.controls['travelFrom'].setValue(tt.travelFrom);
this.formvalue.controls['travelTo'].setValue(tt.travelTo);


}

updatetravelsdetails()
{
this.Travelobj.firstname= this.formvalue.value.firstname;
this.Travelobj.lastname= this.formvalue.value.lastname;
this.Travelobj.gender= this.formvalue.value.gender;
this.Travelobj.phoneno= this.formvalue.value.phoneno;
this.Travelobj.travelFrom= this.formvalue.value.travelFrom;
this.Travelobj.travelTo= this.formvalue.value.travelTo;

this.api.updatetravels(this.Travelobj,this.Travelobj.id)
.subscribe(res=>{
  alert("record updated successfully");
  let ref = document.getElementById('cancel')
  ref?.click();
  this.formvalue.reset();
  this.getTravelsdetails();
})
}
deletetraveldetails(tt:any)
{
this.api.deletetravels(tt.id)
.subscribe(res=>{
  alert("record deleted successfully");
  this.getTravelsdetails();
})
}
}
