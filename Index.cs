@model TahlilYorumlama.Models.TahlilYorumlamaViewModel

<form asp-action="UploadPdf" method="post" enctype="multipart/form-data">
    <div>
        <h2>Kişi Bilgileri</h2>
        <label for="Gender">Cinsiyet:</label>
        <select asp-for="PersonInfo.Gender" class="form-control">
            <option value="">Seçiniz</option>
            <option value="Kadın">Kadın</option>
            <option value="Erkek">Erkek</option>
        </select>
        <br />
        <label for="Age">Yaş:</label>
        <input asp-for="PersonInfo.Age" class="form-control" type="number" min="0" max="200" />
    </div>

    <div>
        <h2>Muayene Bilgileri</h2>
        <label for="Story">Hikaye:</label>
        <input asp-for="ExaminationInfo.Story" class="form-control" />
        <br />
        <label for="Complaint">Şikayet:</label>
        <input asp-for="ExaminationInfo.Complaint" class="form-control" />
        <br />
        <label for="Finding">Bulgu:</label>
        <input asp-for="ExaminationInfo.Finding" class="form-control" />
        <br />
        <label for="Result">Sonuç:</label>
        <input asp-for="ExaminationInfo.Result" class="form-control" />
    </div>

    <div>
        <h2>Girdi Bilgisi</h2>
        <label for="PdfFile">PDF:</label>
        <input asp-for="PdfFile" type="file" class="form-control" />
        <br />
        <button type="submit" class="btn btn-primary">PDF Yükle</button>
        <p>@Model.PdfUploadMessage</p>
    </div>
</form>

<form asp-action="UploadText" method="post" enctype="multipart/form-data">
    <div>
        <h2>Girdi Bilgisi</h2>
        <label for="TextFile">Text:</label>
        <input asp-for="TextFile" type="file" class="form-control" />
        <br />
        <button type="submit" class="btn btn-primary">Text Yükle</button>
        <p>@Model.TextUploadMessage</p>
    </div>
</form>
