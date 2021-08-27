using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class WarehouseEntity
{
    [Key]
    [StringLength(50)]
    public string WarehouseId { get; set; }

    [Required]
    [StringLength(100)]
    public string WarehouseName { get; set; }

    [Required]
    [StringLength(100)]
    public string WarehouseAddress { get; set; }

    //Relacion con almacenamiento (StorageEntity)
    public ICollection<StorageEntity> Storages {get; set;}

}