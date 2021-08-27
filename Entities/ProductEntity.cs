using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class ProductEntity
{
    [Key]
    [StringLength(10)]
    public string ProductId { get; set; }

    [Required]
    [StringLength(100)]
    public string ProductName { get; set; }

    [StringLength(600)]
    public string ProductDescripcion { get; set; }

    public int TotalQuality { get; set; }

    public string CategoryId {get; set;}
    public CategoryEntity Category {get; set;}

    public ICollection<StorageEntity> Storages {get; set;}
}