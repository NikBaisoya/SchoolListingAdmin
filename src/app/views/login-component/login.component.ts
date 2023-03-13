import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validator, Validators } from '@angular/forms';
import { AppService } from 'src/app/app-shared/service/app.service';
import { AuthenticationService } from 'src/app/services/Authentication/authentication.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-login-component',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  public loginForm: FormGroup

  constructor(private fb: FormBuilder, private authService: AuthenticationService, private appService: AppService,
    private router: Router, private activateRoute: ActivatedRoute) {

    this.loginForm = this.fb.group(
      {
        'emailAddress': ['', Validators.compose([Validators.required])],
        'password': ['', Validators.compose([Validators.required])],
      });


  }

  ngOnInit(): void {
  }

  onFormSubmit() {
    debugger;
    if (this.loginForm.valid) {
      const userAuthentication = {
        UserName: this.loginForm.controls["emailAddress"].value,
        Password: this.loginForm.controls["password"].value
      }
      this.authService.authenticateUser(userAuthentication).subscribe((response: any) => {
        debugger;
        if (response?.token) {
          this.appService.setLocalStorageItem("Token", response.token);
          this.appService.setLocalStorageItem("ValidFrom", response.validFrom);
          this.appService.setLocalStorageItem("ValidTo", response.validTo);
          this.router.navigate(["./dashboard"]);



        }

      })


    }
  }

}
