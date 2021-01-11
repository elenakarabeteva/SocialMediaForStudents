import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import Category from '../../shared/models/category';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  private route: string = 'Category';

  constructor(
    private router: Router,
    private http: HttpClient
  ) { }

  create(category: Category) {
    return this.http.post(this.route, category);
  }

  edit(category: Category, id: string) {
    return this.http.put(`${this.route}/${id}`, category);
  }

  delete(id: string) {
    return this.http.delete(`${this.route}/${id}`);
  }

  all() {
    return this.http.get<Category[]>(`${this.route}`);
  }

  getById(id: string) {
    return this.http.get<Category>(`${this.route}/${id}`);
  }
}
