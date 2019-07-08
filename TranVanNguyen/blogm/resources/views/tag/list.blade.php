@extends('layouts.app')

@section('content')
<h2>Tag managements</h2>

<a href="tag/create" class="btn btn-info my-3">New Tag</a>

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
    <td><a href="{{route('tag.show', $cate->id)}}">View</a></td>
    <td><a href="{{route('tag.edit', $cate->id)}}">update</a></td>
    <td>
        <form action="{{route('tag.destroy', $cate->id)}}" method="POST" onsubmit="return confirm('Sure?')">
          @csrf
          <input type="hidden" name="_method" value="DELETE"/>
          <input type="submit" value="delete"/>
        </form> 
      </td>
  </tr>
@endforeach
</table>
@endsection
