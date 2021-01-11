import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot } from '@angular/router';
import { Observable } from 'rxjs';
import Category from '../../shared/models/category';
import { CategoryService } from '../services/category.service';

@Injectable({
  providedIn: 'root'
})

export class CategoryResolver implements Resolve<Category> {
  constructor(private categoryService: CategoryService) { }

  resolve(route: ActivatedRouteSnapshot): Observable<Category> {
    let id = route.params['id'];
    return this.categoryService.getById(id);
  }
}
