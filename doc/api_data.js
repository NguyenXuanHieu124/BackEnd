define({ "api": [
  {
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "optional": false,
            "field": "varname1",
            "description": "<p>No type.</p>"
          },
          {
            "group": "Success 200",
            "type": "String",
            "optional": false,
            "field": "varname2",
            "description": "<p>With type.</p>"
          }
        ]
      }
    },
    "type": "",
    "url": "",
    "version": "0.0.0",
    "filename": "./doc/main.js",
    "group": "C__Users_Root_Angular_highlandcoffee_BackEnd_Qu_n_L__Coffee_doc_main_js",
    "groupTitle": "C__Users_Root_Angular_highlandcoffee_BackEnd_Qu_n_L__Coffee_doc_main_js",
    "name": ""
  },
  {
    "type": "delete",
    "url": "/api/ChiTietHoaDon/DeleteCTHD/:id",
    "title": "Delete ChiTietHoaDon By Id",
    "version": "0.1.0",
    "name": "ChiTietHoaDonById",
    "group": "ChiTietHoaDon",
    "parameter": {
      "fields": {
        "Parameter": [
          {
            "group": "Parameter",
            "type": "Number",
            "optional": false,
            "field": "id",
            "description": "<p>ChiTietHoaDon Unique ID.</p>"
          }
        ]
      }
    },
    "success": {
      "examples": [
        {
          "title": "Success-Response:",
          "content": "HTTP/1.1 200 OK\n\"Deleted successfully\"",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 4xx": [
          {
            "group": "Error 4xx",
            "optional": false,
            "field": "ChiTietHoaDonNotFound",
            "description": "<p>The id of the ChiTietHoaDon was not found.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Error-Response:",
          "content": "HTTP/1.1 404 Not Found\n{\n   \"error\": \"Not Found To Delete\"\n}",
          "type": "json"
        }
      ]
    },
    "filename": "./Quản Lý Coffee/Controllers/ChiTietHoaDonController.cs",
    "groupTitle": "ChiTietHoaDon"
  },
  {
    "type": "post",
    "url": "api/ChiTietHoaDon/CreateCTHD",
    "title": "Create ChiTietHoaDOn",
    "name": "CreateChiTietHonDon",
    "group": "ChiTietHoaDon",
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "HoaDonXuatId",
            "description": "<p>Id of the HoaDonXuat.</p>"
          },
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "SanPhamId",
            "description": "<p>Id of the SanPham.</p>"
          },
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "SoLuong",
            "description": "<p>Count Number of the SanPham.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Success-Response:",
          "content": "HTTP/1.1 200 OK\n{\n   \"HoaDonXuatId\":\"1\",\n   \"SanPhamId\":\"1\",\n   \"SoLuong\":\"1\"\n}",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 4xx": [
          {
            "group": "Error 4xx",
            "optional": false,
            "field": "ChiTietHoaDonNotFound",
            "description": "<p>The ChiTietHoaDon was not found.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Error-Response:",
          "content": "HTTP/1.1 400 Bad Request\n{\n  \"error\": \"The server can not understand the request due to invalid syntax.\"\n}",
          "type": "json"
        }
      ]
    },
    "version": "0.0.0",
    "filename": "./Quản Lý Coffee/Controllers/ChiTietHoaDonController.cs",
    "groupTitle": "ChiTietHoaDon"
  },
  {
    "type": "get",
    "url": "/api/ChiTietHoaDon/GetChiTietHoaDonByid/:id",
    "title": "Get ChiTietHoaDon By Id",
    "version": "0.1.0",
    "name": "GetChiTietHoaDonByid",
    "group": "ChiTietHoaDon",
    "parameter": {
      "fields": {
        "Parameter": [
          {
            "group": "Parameter",
            "type": "Number",
            "optional": false,
            "field": "id",
            "description": "<p>ChiTietHoaDon unique ID.</p>"
          }
        ]
      }
    },
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "HoaDonXuatId",
            "description": "<p>Id of the HoaDonXuat.</p>"
          },
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "SanPhamId",
            "description": "<p>Id of the SanPham.</p>"
          },
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "SoLuong",
            "description": "<p>Count Number of the SanPham.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Success-Response:",
          "content": "HTTP/1.1 200 OK\n {\n   \"HoaDonXuatId\":\"1\",\n   \"SanPhamId\":\"1\",\n   \"SoLuong\":\"1\"\n  },",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 4xx": [
          {
            "group": "Error 4xx",
            "optional": false,
            "field": "ChiTietHoaDonNotFound",
            "description": "<p>The id of the HoaDonXuat was not found.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Error-Response:",
          "content": "HTTP/1.1 404 Not Found\n{\n  \"error\": \"ChiTietHoaDonNotFound\"\n}",
          "type": "json"
        }
      ]
    },
    "filename": "./Quản Lý Coffee/Controllers/ChiTietHoaDonController.cs",
    "groupTitle": "ChiTietHoaDon"
  },
  {
    "type": "get",
    "url": "api/ChiTietHoaDon/GetChiTietHoaDons",
    "title": "Get All ChiTietHoaDon",
    "name": "GetChiTietHoaDons",
    "group": "ChiTietHoaDon",
    "success": {
      "examples": [
        {
          "title": "Success-Response:",
          "content": "HTTP/1.1 200 OK\n[\n  {\n   \"HoaDonXuatId\":\"1\",\n   \"SanPhamId\":\"1\",\n   \"SoLuong\":\"1\"\n  },\n  {\n   \"HoaDonXuatId\":\"2\",\n   \"SanPhamId\":\"2\",\n   \"SoLuong\":\"2\"\n  }\n]",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 4xx": [
          {
            "group": "Error 4xx",
            "optional": false,
            "field": "ChiTietHoaDonNotFound",
            "description": "<p>The id of the HoaDonXuat was not found.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Error-Response:",
          "content": "HTTP/1.1 404 Not Found\n{\n  \"error\": \"NotFound\"\n}",
          "type": "json"
        }
      ]
    },
    "version": "0.0.0",
    "filename": "./Quản Lý Coffee/Controllers/ChiTietHoaDonController.cs",
    "groupTitle": "ChiTietHoaDon"
  },
  {
    "type": "put",
    "url": "api/ChiTietHoaDon/UpdateCTHD",
    "title": "Update ChiTietHoaDon",
    "name": "UpdateChiTietHoaDon",
    "group": "ChiTietHoaDon",
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "HoaDonXuatId",
            "description": "<p>Id of the HoaDonXuat.</p>"
          },
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "SanPhamId",
            "description": "<p>Id of the SanPham.</p>"
          },
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "SoLuong",
            "description": "<p>Count Number of the SanPham.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Success-Response:",
          "content": "HTTP/1.1 200 OK\n   {\n   \"HoaDonXuatId\":\"1\",\n   \"SanPhamId\":\"1\",\n   \"SoLuong\":\"1\"\n  },",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 4xx": [
          {
            "group": "Error 4xx",
            "optional": false,
            "field": "ChiTietHoaDonNotFound",
            "description": "<p>The ChiTietHoaDon was not found.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Error-Response:",
          "content": "HTTP/1.1 404 Not Found\n{\n  \"error\": \"ChiTietHoaDonNotFound\"\n}\nHTTP/1.1 400 Bad Request\n{\n  \"error\": \"The server can not understand the request due to invalid syntax.\"\n}",
          "type": "json"
        }
      ]
    },
    "version": "0.0.0",
    "filename": "./Quản Lý Coffee/Controllers/ChiTietHoaDonController.cs",
    "groupTitle": "ChiTietHoaDon"
  },
  {
    "type": "post",
    "url": "api/HoaDonXuat/create",
    "title": "Create HoaDonXuat",
    "version": "0.1.0",
    "name": "CreateHoaDonXuat",
    "group": "HoaDonXuat",
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "HoaDonXuatId",
            "description": "<p>Id of the HoaDonXuat.</p>"
          },
          {
            "group": "Success 200",
            "type": "String",
            "optional": false,
            "field": "DaThanhToan",
            "description": "<p>Status of the HoaDonXuat.</p>"
          },
          {
            "group": "Success 200",
            "type": "String",
            "optional": false,
            "field": "HinhThucThanhToan",
            "description": "<p>Description of the HoaDonXuat.</p>"
          },
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "BanId",
            "description": "<p>Id of the Ban.</p>"
          },
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "ChiNhanhId",
            "description": "<p>Id of the ChiNhanh.</p>"
          },
          {
            "group": "Success 200",
            "type": "DateTime",
            "optional": false,
            "field": "NgayGio",
            "description": "<p>Create day of the HoaDonXuat.</p>"
          },
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "TongTien",
            "description": "<p>Total payment the HoaDonXuat.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Success-Response:",
          "content": "HTTP/1.1 200 OK\n \"Created Successfully\"",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 4xx": [
          {
            "group": "Error 4xx",
            "optional": false,
            "field": "HoaDonXuatNotFound",
            "description": "<p>The HoaDonXuat was not found.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Error-Response:",
          "content": "HTTP/1.1 400 Bad Request\n{\n  \"error\": \"The server can not understand the request due to invalid syntax.\"\n}",
          "type": "json"
        }
      ]
    },
    "filename": "./Quản Lý Coffee/Controllers/HoaDonXuatController.cs",
    "groupTitle": "HoaDonXuat"
  },
  {
    "type": "delete",
    "url": "/api/HoaDonXuat/delete/:id",
    "title": "Delete HoaDonXuat By Id",
    "version": "0.1.0",
    "name": "DeleteHoaDonXuatById",
    "group": "HoaDonXuat",
    "parameter": {
      "fields": {
        "Parameter": [
          {
            "group": "Parameter",
            "type": "Number",
            "optional": false,
            "field": "id",
            "description": "<p>HoaDonXuat Unique ID.</p>"
          }
        ]
      }
    },
    "success": {
      "examples": [
        {
          "title": "Success-Response:",
          "content": "HTTP/1.1 200 OK\n\"Deleted successfully\"",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 4xx": [
          {
            "group": "Error 4xx",
            "optional": false,
            "field": "HoaDonXuatNotFound",
            "description": "<p>The id of the HoaDonXuat was not found.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Error-Response:",
          "content": "HTTP/1.1 404 Not Found\n{\n   \"error\": \"Not Found To Delete\"\n}",
          "type": "json"
        }
      ]
    },
    "filename": "./Quản Lý Coffee/Controllers/HoaDonXuatController.cs",
    "groupTitle": "HoaDonXuat"
  },
  {
    "type": "get",
    "url": "api/HoaDonXuat/gethoadonxuats",
    "title": "Get All HoaDonXuat",
    "name": "GetAllHoaDonXuat",
    "group": "HoaDonXuat",
    "success": {
      "examples": [
        {
          "title": "Success-Response:",
          "content": " HTTP/1.1 200 OK\n [\n   {\n        \"HoaDonXuatId\": 3,\n        \"NgayGio\": \"2018-11-27T00:00:00\",\n        \"HinhThucThanhToan\": null,\n        \"TongTien\": 0,\n        \"DaThanhToan\": false,\n        \"ChiNhanhId\": 1,\n        \"BanId\": 1\n    },\n    {\n        \"HoaDonXuatId\": 2,\n        \"NgayGio\": \"2018-11-27T00:00:00\",\n        \"HinhThucThanhToan\": null,\n        \"TongTien\": 0,\n        \"DaThanhToan\": false,\n        \"ChiNhanhId\": 1,\n        \"BanId\": 2\n    }\n]",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 4xx": [
          {
            "group": "Error 4xx",
            "optional": false,
            "field": "HoaDonXuatNotFound",
            "description": "<p>The id of the HoaDonXuat was not found.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Error-Response:",
          "content": "HTTP/1.1 404 Not Found\n{\n  \"error\": \"NotFound\"\n}",
          "type": "json"
        }
      ]
    },
    "version": "0.0.0",
    "filename": "./Quản Lý Coffee/Controllers/HoaDonXuatController.cs",
    "groupTitle": "HoaDonXuat"
  },
  {
    "type": "get",
    "url": "/api/HoaDonXuat/getbyid/:id",
    "title": "Get HoaDonXuat By Id",
    "version": "0.1.0",
    "name": "GetHoaDonXuatById",
    "group": "HoaDonXuat",
    "parameter": {
      "fields": {
        "Parameter": [
          {
            "group": "Parameter",
            "type": "Number",
            "optional": false,
            "field": "id",
            "description": "<p>HoaDonXuat unique ID.</p>"
          }
        ]
      }
    },
    "success": {
      "examples": [
        {
          "title": "Success-Response:",
          "content": "HTTP/1.1 200 OK\n  {\n       \"HoaDonXuatId\": 2,\n       \"NgayGio\": \"2018-11-27T00:00:00\",\n       \"HinhThucThanhToan\": null,\n       \"TongTien\": 0,\n       \"DaThanhToan\": false,\n       \"ChiNhanhId\": 1,\n       \"BanId\": 2\n  }",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 4xx": [
          {
            "group": "Error 4xx",
            "optional": false,
            "field": "HoaDonXuatNotFound",
            "description": "<p>The id of the HoaDonXuat was not found.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Error-Response:",
          "content": "HTTP/1.1 404 Not Found\n{\n  \"error\": \"HoaDonXuatNotFound\"\n}",
          "type": "json"
        }
      ]
    },
    "filename": "./Quản Lý Coffee/Controllers/HoaDonXuatController.cs",
    "groupTitle": "HoaDonXuat"
  },
  {
    "type": "put",
    "url": "api/HoaDonXuat/update",
    "title": "Update HoaDonXuat",
    "name": "UpdateHoaDonXuat",
    "group": "HoaDonXuat",
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "HoaDonXuatId",
            "description": "<p>Id of the HoaDonXuat.</p>"
          },
          {
            "group": "Success 200",
            "type": "String",
            "optional": false,
            "field": "DaThanhToan",
            "description": "<p>Status of the HoaDonXuat.</p>"
          },
          {
            "group": "Success 200",
            "type": "String",
            "optional": false,
            "field": "HinhThucThanhToan",
            "description": "<p>Description of the HoaDonXuat.</p>"
          },
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "BanId",
            "description": "<p>Id of the Ban.</p>"
          },
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "ChiNhanhId",
            "description": "<p>Id of the ChiNhanh.</p>"
          },
          {
            "group": "Success 200",
            "type": "DateTime",
            "optional": false,
            "field": "NgayGio",
            "description": "<p>Create day of the HoaDonXuat.</p>"
          },
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "TongTien",
            "description": "<p>Total payment the HoaDonXuat.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Success-Response:",
          "content": "HTTP/1.1 200 OK\n  {\n       \"HoaDonXuatId\": 2,\n       \"NgayGio\": \"2018-11-27T00:00:00\",\n       \"HinhThucThanhToan\": null,\n       \"TongTien\": 0,\n       \"DaThanhToan\": false,\n       \"ChiNhanhId\": 1,\n       \"BanId\": 2\n  }",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 4xx": [
          {
            "group": "Error 4xx",
            "optional": false,
            "field": "HoaDonXuatNotFound",
            "description": "<p>The HoaDonXuat was not found.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Error-Response:",
          "content": "HTTP/1.1 404 Not Found\n{\n  \"error\": \"HoaDonXuatNotFound\"\n}\nHTTP/1.1 400 Bad Request\n{\n  \"error\": \"The server can not understand the request due to invalid syntax.\"\n}",
          "type": "json"
        }
      ]
    },
    "version": "0.0.0",
    "filename": "./Quản Lý Coffee/Controllers/HoaDonXuatController.cs",
    "groupTitle": "HoaDonXuat"
  },
  {
    "type": "put",
    "url": "api/SanPham/createsanpham",
    "title": "Create Product",
    "name": "CreateProduct",
    "group": "Product",
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "SanPhamId",
            "description": "<p>Id of the Product.</p>"
          },
          {
            "group": "Success 200",
            "type": "String",
            "optional": false,
            "field": "TenSP",
            "description": "<p>Name of the Product.</p>"
          },
          {
            "group": "Success 200",
            "type": "String",
            "optional": false,
            "field": "MoTa",
            "description": "<p>Description of the Product.</p>"
          },
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "Gia",
            "description": "<p>Price of the Product.</p>"
          },
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "LoaiSPId",
            "description": "<p>Id of the LoaiSP.</p>"
          },
          {
            "group": "Success 200",
            "type": "String",
            "optional": false,
            "field": "LinkImage",
            "description": "<p>Link image of the Product.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Success-Response:",
          "content": "HTTP/1.1 200 OK\n \"Created Successfully\"",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 4xx": [
          {
            "group": "Error 4xx",
            "optional": false,
            "field": "ProductNotFound",
            "description": "<p>The Product was not found.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Error-Response:",
          "content": "HTTP/1.1 400 Bad Request\n{\n  \"error\": \"The server can not understand the request due to invalid syntax.\"\n}",
          "type": "json"
        }
      ]
    },
    "version": "0.0.0",
    "filename": "./Quản Lý Coffee/Controllers/SanPhamController.cs",
    "groupTitle": "Product"
  },
  {
    "type": "get",
    "url": "/api/SanPham/deletesanpham/:id",
    "title": "Delete Product By Id",
    "version": "0.1.0",
    "name": "DeleteProductById",
    "group": "Product",
    "parameter": {
      "fields": {
        "Parameter": [
          {
            "group": "Parameter",
            "type": "Number",
            "optional": false,
            "field": "id",
            "description": "<p>Product Unique ID.</p>"
          }
        ]
      }
    },
    "success": {
      "examples": [
        {
          "title": "Success-Response:",
          "content": "HTTP/1.1 200 OK\n\"Deleted successfully\"",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 4xx": [
          {
            "group": "Error 4xx",
            "optional": false,
            "field": "ProductNotFound",
            "description": "<p>The id of the Product was not found.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Error-Response:",
          "content": "HTTP/1.1 404 Not Found\n{\n   \"error\": \"Not Found To Delete\"\n}",
          "type": "json"
        }
      ]
    },
    "filename": "./Quản Lý Coffee/Controllers/SanPhamController.cs",
    "groupTitle": "Product"
  },
  {
    "type": "get",
    "url": "api/SanPham/GetSanPhams",
    "title": "Get All Product",
    "name": "GetAllProduct",
    "group": "Product",
    "success": {
      "examples": [
        {
          "title": "Success-Response:",
          "content": "HTTP/1.1 200 OK\n[\n  {\n  \"SanPhamId\":\"1\",\n  \"TenSP\":\"Cafe sữa\",\n  \"Gia\":\"19000\",\n  \"MoTa\":\"Lorem ipsum dolor sit amet, consectetur adipiscing elit. \n  Mauris euismod fringilla interdum.\",\n  \"LinkImage\":\"http://localhost:8088/Image/tenanh\"\n  },\n  {\n  \"SanPhamId\":\"2\",\n  \"TenSP\":\"Cafe Đá\",\n  \"Gia\":\"11000\",\n  \"MoTa\":\"Lorem ipsum dolor sit amet, consectetur adipiscing elit. \n  Mauris euismod fringilla interdum.\",\n  \"LinkImage\":\"http://localhost:8088/Image/tenanh\"\n  }\n]",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 4xx": [
          {
            "group": "Error 4xx",
            "optional": false,
            "field": "ProductNotFound",
            "description": "<p>The id of the Product was not found.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Error-Response:",
          "content": "HTTP/1.1 404 Not Found\n{\n  \"error\": \"NotFound\"\n}",
          "type": "json"
        }
      ]
    },
    "version": "0.0.0",
    "filename": "./Quản Lý Coffee/Controllers/SanPhamController.cs",
    "groupTitle": "Product"
  },
  {
    "type": "get",
    "url": "/api/SanPham/getsanphambyid/:id",
    "title": "Get Product By Id",
    "version": "0.1.0",
    "name": "GetProduct",
    "group": "Product",
    "parameter": {
      "fields": {
        "Parameter": [
          {
            "group": "Parameter",
            "type": "Number",
            "optional": false,
            "field": "id",
            "description": "<p>Product unique ID.</p>"
          }
        ]
      }
    },
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "SanPhamId",
            "description": "<p>Id of the Product.</p>"
          },
          {
            "group": "Success 200",
            "type": "String",
            "optional": false,
            "field": "TenSP",
            "description": "<p>Name of the Product.</p>"
          },
          {
            "group": "Success 200",
            "type": "String",
            "optional": false,
            "field": "MoTa",
            "description": "<p>Description of the Product.</p>"
          },
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "Gia",
            "description": "<p>Price of the Product.</p>"
          },
          {
            "group": "Success 200",
            "type": "String",
            "optional": false,
            "field": "LinkImage",
            "description": "<p>Link image of the Product.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Success-Response:",
          "content": "HTTP/1.1 200 OK\n  {\n  \"SanPhamId\":\"1\",\n  \"TenSP\":\"Cafe sữa\",\n  \"Gia\":\"19000\",\n  \"MoTa\":\"Lorem ipsum dolor sit amet, consectetur adipiscing elit. \n   Mauris euismod fringilla interdum.\",\n  \"LinkImage\":\"http://localhost:8088/Image/tenanh\"\n  },",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 4xx": [
          {
            "group": "Error 4xx",
            "optional": false,
            "field": "ProductNotFound",
            "description": "<p>The id of the Category was not found.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Error-Response:",
          "content": "HTTP/1.1 404 Not Found\n{\n  \"error\": \"ProductNotFound\"\n}",
          "type": "json"
        }
      ]
    },
    "filename": "./Quản Lý Coffee/Controllers/SanPhamController.cs",
    "groupTitle": "Product"
  },
  {
    "type": "get",
    "url": "/api/SanPham/getsanphambycategory/:id",
    "title": "Get All Product By Category Id",
    "version": "0.1.0",
    "name": "GetProductByCategoryId",
    "group": "Product",
    "parameter": {
      "fields": {
        "Parameter": [
          {
            "group": "Parameter",
            "type": "Number",
            "optional": false,
            "field": "id",
            "description": "<p>Category ID.</p>"
          }
        ]
      }
    },
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "SanPhamId",
            "description": "<p>Id of the Product.</p>"
          },
          {
            "group": "Success 200",
            "type": "String",
            "optional": false,
            "field": "TenSP",
            "description": "<p>Name of the Product.</p>"
          },
          {
            "group": "Success 200",
            "type": "String",
            "optional": false,
            "field": "MoTa",
            "description": "<p>Description of the Product.</p>"
          },
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "Gia",
            "description": "<p>Price of the Product.</p>"
          },
          {
            "group": "Success 200",
            "type": "String",
            "optional": false,
            "field": "LinkImage",
            "description": "<p>Link image of the Product.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Success-Response:",
          "content": "HTTP/1.1 200 OK\n[\n  {\n  \"SanPhamId\":\"1\",\n  \"TenSP\":\"Cafe sữa\",\n  \"Gia\":\"19000\",\n  \"MoTa\":\"Lorem ipsum dolor sit amet, consectetur adipiscing elit. \n  Mauris euismod fringilla interdum.\",\n  \"LinkImage\":\"http://localhost:8088/Image/tenanh\"\n  },\n  {\n  \"SanPhamId\":\"2\",\n  \"TenSP\":\"Cafe Đá\",\n  \"Gia\":\"11000\",\n  \"MoTa\":\"Lorem ipsum dolor sit amet, consectetur adipiscing elit. \n  Mauris euismod fringilla interdum.\",\n  \"LinkImage\":\"http://localhost:8088/Image/tenanh\"\n  }\n]",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 4xx": [
          {
            "group": "Error 4xx",
            "optional": false,
            "field": "ProductNotFound",
            "description": "<p>The id of the Category was not found.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Error-Response:",
          "content": "HTTP/1.1 404 Not Found\n{\n  \"error\": \"ProductNotFound\"\n}",
          "type": "json"
        }
      ]
    },
    "filename": "./Quản Lý Coffee/Controllers/SanPhamController.cs",
    "groupTitle": "Product"
  },
  {
    "type": "put",
    "url": "api/SanPham/updatesanpham",
    "title": "Update Product",
    "name": "UpdateProduct",
    "group": "Product",
    "success": {
      "fields": {
        "Success 200": [
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "SanPhamId",
            "description": "<p>Id of the Product.</p>"
          },
          {
            "group": "Success 200",
            "type": "String",
            "optional": false,
            "field": "TenSP",
            "description": "<p>Name of the Product.</p>"
          },
          {
            "group": "Success 200",
            "type": "String",
            "optional": false,
            "field": "MoTa",
            "description": "<p>Description of the Product.</p>"
          },
          {
            "group": "Success 200",
            "type": "int",
            "optional": false,
            "field": "Gia",
            "description": "<p>Price of the Product.</p>"
          },
          {
            "group": "Success 200",
            "type": "String",
            "optional": false,
            "field": "LinkImage",
            "description": "<p>Link image of the Product.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Success-Response:",
          "content": "HTTP/1.1 200 OK\n  {\n  \"SanPhamId\":\"1\",\n  \"TenSP\":\"Cafe sữa\",\n  \"Gia\":\"19000\",\n  \"MoTa\":\"Lorem ipsum dolor sit amet, consectetur adipiscing elit. \n   Mauris euismod fringilla interdum.\",\n  \"LinkImage\":\"http://localhost:8088/Image/tenanh\"\n  },",
          "type": "json"
        }
      ]
    },
    "error": {
      "fields": {
        "Error 4xx": [
          {
            "group": "Error 4xx",
            "optional": false,
            "field": "ProductNotFound",
            "description": "<p>The Product was not found.</p>"
          }
        ]
      },
      "examples": [
        {
          "title": "Error-Response:",
          "content": "HTTP/1.1 404 Not Found\n{\n  \"error\": \"ProductNotFound\"\n}\nHTTP/1.1 400 Bad Request\n{\n  \"error\": \"The server can not understand the request due to invalid syntax.\"\n}",
          "type": "json"
        }
      ]
    },
    "version": "0.0.0",
    "filename": "./Quản Lý Coffee/Controllers/SanPhamController.cs",
    "groupTitle": "Product"
  }
] });
