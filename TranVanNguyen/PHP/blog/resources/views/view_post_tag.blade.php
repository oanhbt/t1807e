@extends('layouts.frontend')
@section('content')
<section class="site-section pt-5">
    <div class="container">
      <div class="row mb-4">
        <div class="col-md-6">
        <h2 class="mb-4">Tag: {{$tag -> name}}</h2>
        </div>
      </div>
      <div class="row blog-entries">
        <div class="col-md-12 col-lg-8 main-content">
          <div class="row mb-5 mt-5">

            <div class="col-md-12">
              @foreach ($lsPost as $post)
              <div class="post-entry-horzontal">
                  <a href="blog-single.html">
                    <div class="image element-animate" data-animate-effect="fadeIn" style="background-image: url({{$post -> cover}});"></div>
                    <span class="text">
                      <div class="post-meta">
                      <span class="author mr-2"><img src="images/person_1.jpg" alt="Colorlib"> {{$post -> User -> name}}</span>&bullet;
                        <span class="mr-2">{{date('M d Y', strtotime($post -> created_at))}} </span> &bullet;
                        <span class="mr-2">{{$tag -> name}}</span> &bullet;
                        <span class="ml-2"><span class="fa fa-comments"></span> 3</span>
                      </div>
                    <h2>{{$post -> title}}</h2>
                    </span>
                  </a>
                </div>
                <!-- END post -->
              @endforeach
              

            </div>
          </div>

          <div class="row mt-5">
            <div class="col-md-12 text-center">
              <nav aria-label="Page navigation" class="text-center">
                <ul class="pagination">
                  {{$lsPost -> links()}}
                </ul>
              </nav>
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
              <img src="images/person_2.jpg" alt="Image Placeholder" class="img-fluid">
              <div class="bio-body">
                <h2>Craig David</h2>
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
                      <h4>There’s a Cool New Way for Men to Wear Socks and Sandals</h4>
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
                      <h4>There’s a Cool New Way for Men to Wear Socks and Sandals</h4>
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
                      <h4>There’s a Cool New Way for Men to Wear Socks and Sandals</h4>
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
                @foreach ($lsCate as $cate)
                  <li><a href="view_post_cate/{{$cate -> id}}">{{$cate -> name}} <span>({{$cate -> posts -> count()}})</span></a></li>
                @endforeach
            </ul>
          </div>
          <!-- END sidebar-box -->

          <div class="sidebar-box">
            <h3 class="heading">Tags</h3>
            <ul class="tags">
                @foreach ($lsTag as $tag)
                  <li><a href="view_post_tag/{{$tag->id}}">{{$tag -> name}}</a></li>
                @endforeach
            </ul>
          </div>
        </div>
        <!-- END sidebar -->

      </div>
    </div>
  </section>
      <section class="site-section py-sm">
        <div class="container">
          <div class="row">
            <div class="col-md-6">
            <h2 class="mb-4">{{$tag -> name}}</h2>
            </div>
          </div>
          <div class="row blog-entries">
            <div class="col-md-12 col-lg-8 main-content">
              <div class="row">

                @foreach ($tag -> posts as $item)
                  <div class="col-md-6">
                    <a href="view_post/{{$item -> id}}" class="blog-entry element-animate" data-animate-effect="fadeIn">
                        <img src="{{$item -> cover}}" alt="Image placeholder">
                        <div class="blog-content-body">
                            <div class="post-meta">
                            {{-- <span class="author mr-2"><img src="images/person_1.jpg" alt="Colorlib"> {{$item -> User -> name}}</span>&bullet; --}}
                            <span class="mr-2">{{date('M d Y', strtotime($item -> created_at))}} </span> &bullet;
                            <span class="ml-2"><span class="fa fa-comments"></span> 3</span>
                            </div>
                            <h2>{{$item -> title}}</h2>
                        </div>
                    </a>
                  </div>
                @endforeach
                

              </div>

              <div class="row mt-5">
                <div class="col-md-12 text-center">
                  <nav aria-label="Page navigation" class="text-center">
                    {{-- {{$lsPost -> links()}} --}}
                  </nav>
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
                  @foreach ($lsCate as $cate)
                    <li><a href="view_post_cate/{{$cate -> id}}">{{$cate -> name}} <span>({{$cate -> posts -> count()}})</span></a></li>
                  @endforeach

                </ul>
              </div>
              <!-- END sidebar-box -->

              <div class="sidebar-box">
                <h3 class="heading">Tags</h3>
                <ul class="tags">
                  @foreach ($lsTag as $tag)
                      <li><a href="view_post_tag/{{$tag -> id}}">{{$tag -> name}}</a></li>
                  @endforeach
                  

                </ul>
              </div>
            </div>
            <!-- END sidebar -->

          </div>
        </div>
      </section>
    
@endsection