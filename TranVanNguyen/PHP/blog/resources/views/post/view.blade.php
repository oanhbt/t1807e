@extends('layouts.app')

@section('content')
<div class="container">
  <h2>Post managements</h2>
  Title:    <p>{{$post->title}}</p>
  <br/>
  Cover:    <br/><img src="/blog/public/{{$post->cover}}" alt=""  width="50%">
            
  <br/>
  Content:  <p>{!!$post->content!!}</p>
  
  <br/>
  <a href="{{route('post.index')}}">Back</a>
</div>
@endsection
