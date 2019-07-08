@extends('layouts.app')

@section('content')
<div class="container">
  <h2>Tag managements</h2>
  Name:    <p>{{$cate->name}}</p>
  <br/>
  <a href="{{route('tag.index')}}">Back</a>
</div>
@endsection
