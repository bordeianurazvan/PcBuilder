import { Injectable } from '@angular/core';
import { Post } from '../models/post';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../../../environments/environment';

@Injectable()
export class CommunityService {
  post: Post;
  baseUrl: string;

  constructor(private http: HttpClient) {
    this.post = new Post();
    this.baseUrl = environment.apiUrl;
  }

  public get posts() {
    const baseUrl = this.baseUrl;
    return {
      getById: (id: string) => {
        const url = `${baseUrl}/api/posts/${id}`;
        return this.http.get<Post>(url);
      },
      getAll: () => {
        const url = `${baseUrl}/api/posts`;
        return this.http.get<Post[]>(url);
      },
      insert: (post: Post) => {
        const url = `${baseUrl}/api/posts`;
        return this.http.post<Post>(url, post);
      }
    };
  }
}
