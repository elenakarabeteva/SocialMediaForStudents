import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { Subject } from 'rxjs';
import { globalConstants } from '../../common/global-constants';
import User from '../../shared/models/user';
import * as jwtDecode from "jwt-decode";

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  root: string = "Profile";

  constructor(
    private router: Router,
    private http: HttpClient
  ) { }

  public isAuth = false;
  public isAdmin = false;
  public username: string;
  public role: string;
  isAuthChanged = new Subject<boolean>();

  initializeAuthenticationState() {
    let token = this.getToken();
    if (!token) {
      this.isAuth = false;
      this.isAdmin = false;
      this.username = "";
    }
    else {
      try {
        var tokenData = jwtDecode(token);
        this.username = tokenData['unique_name'];
        this.isAuth = true;
        this.isAdmin = tokenData["role"] === "Administrator";
        this.role = tokenData["role"];
      }
      catch (Error) {
        this.isAuth = false;
        this.isAdmin = false;
        this.username = "";
      }
    }

    this.isAuthChanged.next(true);
  }

  getToken(): string {
    return localStorage.getItem(globalConstants.jwtTokenKey);
  }

  setToken(token: string) {
    return localStorage.setItem(globalConstants.jwtTokenKey, token);
  }

  create(user: User) {
    return this.http.post(`${this.root}/Create`, user);
  }

  login(username: string, password: string) {
    return this.http.post(`${this.root}/Login`, { username, password });
  }

  logout() {
    localStorage.clear();
  }
}
