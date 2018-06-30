import { Component, OnInit } from '@angular/core';
import { CommunityService } from '../../shared/services/community.service';
import { Router } from '@angular/router';
import { Post } from '../../shared/models/post';

@Component({
  selector: 'app-community',
  templateUrl: './community.component.html',
  styleUrls: ['./community.component.css']
})
export class CommunityComponent implements OnInit {
  posts: Post[];
  exist = false;

  constructor(private router: Router, private communityService: CommunityService) {}

  goToDetails(post: Post) {
    const postId = post ? post.id : null;
    this.router.navigate(['community/' + postId]);
  }

  ngOnInit() {
    this.communityService.posts.getAll().subscribe(
      response => {
        this.posts = response;
        if (this.posts.length !== 0) {
          this.exist = true;
        }
      },
      error => {
        console.log('error');
      }
    );
  }
}
