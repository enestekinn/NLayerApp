using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class CustomResponseDto<T>
    {


        public T Data { get; set; }


        [JsonIgnore]
        public int StatusCode { get; set; }


        // birden cok hata olabilir o yuzden liste seklinde tutuyoruz.
        public List<string> Errors { get; set; }

     
        public static CustomResponseDto<T> Success(int statusCode,T data)
        {
            return new CustomResponseDto<T> { Data = data, StatusCode = statusCode, Errors = null };
        }
        // Update yapildiginda response'da data olmasina gerek yok.
        public static CustomResponseDto<T> Success(int statusCode)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode};
        }

        public static CustomResponseDto<T> Fail(int statusCode,List<string> erros)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode,Errors = erros };
        }
    

        // bazen sadece bir tane error ihtiyacimiz olur.
        public static CustomResponseDto<T> Fail(int statusCode,string error)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Errors  = new List<string> { error } }; 
        }









    }
}
