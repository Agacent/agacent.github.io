using minor.Shopify.Post;

public class Body{
    public string title{get;set;}
    public string product_type{get;set;}
    public string body_html{get;set;}
    public string vendor{get;set;}
    public List<images> images{get;set;}
    public List<variantsP> variants{get;set;}
    public List<optionsP> options{get;set;}
    public string status{get;set;}
}