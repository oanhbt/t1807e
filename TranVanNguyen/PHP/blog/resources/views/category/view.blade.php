@extends('layouts.app')

@section('content')
<div class="container">
  <h2>Category managements</h2>
  Name:    <p>{{$cate->name}}</p>
  <br/>
  <a href="{{route('category.index')}}">Back</a>
</div>
@endsection
