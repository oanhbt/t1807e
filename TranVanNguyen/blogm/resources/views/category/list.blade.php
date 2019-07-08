@extends('layouts.app')

@section('content')
<h2>Category managements</h2>

<a href="category/create" class="btn btn-info my-3">New Category</a>

@foreach (['success','danger'] as $msg)
  @if(session($msg))
    <div class="alert alert-{{$msg}}">
      {{session($msg)}}
    </div>
  @endif
@endforeach


@if(session('success'))
  <div class="alert alert-info">
    {{session('success')}}
  </div>
@endif

@if(session('danger'))
  <div class="alert alert-danger">
    {{session('success')}}
  </div>
@endif

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
    <td>
      <form action="{{route('category.destroy', $cate->id)}}" method="POST" onsubmit="return confirm('Sure?')">
        @csrf
        <input type="hidden" name="_method" value="DELETE"/>
        <input type="submit" value="delete"/>
      </form> 
    </td>
  </tr>
@endforeach
</table>
@endsection
