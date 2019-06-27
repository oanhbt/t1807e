@extends('layouts.app')

@section('content')
<h2>Category managements</h2>

<a href="category/create" class="btn btn-info my-3">New Category</a>

<table class="table">
  <tr>
    <th>No</th>
    <th>Name</th>
    <th>View</th>
    <th>Edit</th>
    <th>Delete</th>
  </tr>
@foreach($lsCate as $i => $cate)
  <tr>
    <td>{{$i + 1}}</td>
    <td>{{$cate->name}}</td>
    <td><a href="{{route('category.show', $cate->id)}}">View</a></td>
    <td><a href="{{route('category.edit', $cate->id)}}">update</a></td>
    <td></td>
  </tr>
@endforeach
</table>
@endsection
