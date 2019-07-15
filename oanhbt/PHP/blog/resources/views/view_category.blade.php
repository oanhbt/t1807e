@extends('layouts.frontend')

@section('content')
      <section class="site-section py-sm">
        <div class="container">
          <div class="row mb-4">
            <div class="col-md-6">
              <h2 class="mb-4">Category: {{$category->name}}</h2>
            </div>
          </div>
          <div class="row blog-entries">
            <div class="col-md-12 col-lg-8 main-content">
              <div class="row">

                @foreach($lsPost as $post)
                <div class="post-entry-horzontal">
                  <a href="blog-single.html">
                    <div class="image element-animate" data-animate-effect="fadeIn"
                    style="background-image: url({{$post->cover}});"></div>
                    <span class="text">
                      <div class="post-meta">
                        <span class="author mr-2"><img src="images/person_1.jpg"
                          alt="Colorlib"> Colorlib</span>&bullet;
                        <span class="mr-2">March 15, 2018 </span> &bullet;
                        <span class="mr-2">Food</span> &bullet;
                        <span class="ml-2"><span class="fa fa-comments"></span> 3</span>
                      </div>
                      <h2>{{$post->content}}</h2>
                    </span>
                  </a>
                </div>
                @endforeach
              </div>
              <div class="row">
              <div class="row mt-5">
                <div class="col-md-12 text-center">
                  <nav aria-label="Page navigation" class="text-center">
                      {{$lsPost->links()}}
                  </nav>
                </div>
              </div>

            </div>
          </div>
            <!-- END main-content -->

            <div class="col-md-12 col-lg-4 sidebar">
              <div class="sidebar-box search-form-wrap">
                <form action="#" class="search-form">
                  <div class="form-group">
                    <span class="icon fa fa-search"></span>
                    <input type="text" class="form-control" id="s" placeholder="Type a keyword and hit enter">
                  </div>
                </form>
              </div>
              <!-- END sidebar-box -->
              <div class="sidebar-box">
                <div class="bio text-center">
                  <img src="images/person_1.jpg" alt="Image Placeholder" class="img-fluid">
                  <div class="bio-body">
                    <h2>David Craig</h2>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Exercitationem facilis sunt repellendus excepturi beatae porro debitis voluptate nulla quo veniam fuga sit molestias minus.</p>
                    <p><a href="#" class="btn btn-primary btn-sm rounded">Read my bio</a></p>
                    <p class="social">
                      <a href="#" class="p-2"><span class="fa fa-facebook"></span></a>
                      <a href="#" class="p-2"><span class="fa fa-twitter"></span></a>
                      <a href="#" class="p-2"><span class="fa fa-instagram"></span></a>
                      <a href="#" class="p-2"><span class="fa fa-youtube-play"></span></a>
                    </p>
                  </div>
                </div>
              </div>
              <!-- END sidebar-box -->
              <div class="sidebar-box">
                <h3 class="heading">Popular Posts</h3>
                <div class="post-entry-sidebar">
                  <ul>
                    <li>
                      <a href="">
                        <img src="images/img_2.jpg" alt="Image placeholder" class="mr-4">
                        <div class="text">
                          <h4>How to Find the Video Games of Your Youth</h4>
                          <div class="post-meta">
                            <span class="mr-2">March 15, 2018 </span>
                          </div>
                        </div>
                      </a>
                    </li>
                    <li>
                      <a href="">
                        <img src="images/img_4.jpg" alt="Image placeholder" class="mr-4">
                        <div class="text">
                          <h4>How to Find the Video Games of Your Youth</h4>
                          <div class="post-meta">
                            <span class="mr-2">March 15, 2018 </span>
                          </div>
                        </div>
                      </a>
                    </li>
                    <li>
                      <a href="">
                        <img src="images/img_12.jpg" alt="Image placeholder" class="mr-4">
                        <div class="text">
                          <h4>How to Find the Video Games of Your Youth</h4>
                          <div class="post-meta">
                            <span class="mr-2">March 15, 2018 </span>
                          </div>
                        </div>
                      </a>
                    </li>
                  </ul>
                </div>
              </div>
              <!-- END sidebar-box -->

              <div class="sidebar-box">
                <h3 class="heading">Categories</h3>
                <ul class="categories">

                  @foreach($lsCategory as $cate)
                  <li><a href="category/{{$cate->id}}">{{ $cate->name}} <span>
                      ({{ $cate->posts->count()}}) </span></a></li>
                  @endforeach
                </ul>
              </div>
              <!-- END sidebar-box -->

              <div class="sidebar-box">
                <h3 class="heading">Tags</h3>
                <ul class="tags">
                  @foreach($lsTag as $tag)
                  <li><a href="#">{{ $tag->name }}</a></li>
                  @endforeach
                </ul>
              </div>
            </div>
            <!-- END sidebar -->

          </div>
        </div>
      </section>

@endsection
