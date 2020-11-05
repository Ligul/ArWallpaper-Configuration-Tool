#!/usr/bin/env python3


from re import search
import gi
gi.require_version('Gtk', '3.0')
from gi.repository import Gtk


class MainWindow(Gtk.Window):
  def __init__(self):
    self.config = {}
    self.readConfig(self.config)
    print(self.config)

    Gtk.Window.__init__(self, title="ArWallpaper configurator", type=Gtk.WindowType.TOPLEVEL)
    self.set_resizable(False)
    self.set_border_width(10)

    grid = Gtk.Grid(row_spacing=5)
    self.add(grid)

    ########### Model path ###########
    model_box = Gtk.Box(spacing=5)
    grid.add(model_box)

    self.model_file_chooser = Gtk.FileChooserButton()
    self.model_file_chooser.set_hexpand(True)
    self.model_file_chooser.set_filename(self.config["modelPath"])

    model_label = Gtk.Label(label="Model path:")

    model_box.add(model_label)
    model_box.add(self.model_file_chooser)

    ########### Camera settings ###########
    camera_frame = Gtk.Frame(label="Camera settings", label_xalign=0.05)
    grid.attach_next_to(camera_frame, model_box,
              Gtk.PositionType.BOTTOM, 1, 1)

    camera_frame_grid = Gtk.Grid(column_spacing=5)
    camera_frame_grid.set_border_width(5)

    camera_frame.add(camera_frame_grid)

    self.camera_capture_device = Gtk.SpinButton(
      adjustment=Gtk.Adjustment(
        value=0, lower=0, upper=100, step_increment=1, page_increment=0, page_size=0
      ),
      climb_rate=0, digits=0
    )
    self.camera_capture_device.set_value(
      int(self.config["videoCaptureDevice"]))

    self.camera_near = Gtk.SpinButton(
      adjustment=Gtk.Adjustment(
        value=0, lower=0, upper=100, step_increment=1, page_increment=0, page_size=0
      ),
      climb_rate=0, digits=0
    )
    self.camera_near.set_value(int(self.config["cameraNear"]))

    self.camera_far = Gtk.SpinButton(
      adjustment=Gtk.Adjustment(
        value=0, lower=0, upper=100, step_increment=1, page_increment=0, page_size=0
      ),
      climb_rate=0, digits=0
    )
    self.camera_far.set_value(int(self.config["cameraFar"]))

    self.camera_ratio = Gtk.SpinButton(
      adjustment=Gtk.Adjustment(
        value=0, lower=0, upper=1, step_increment=0.1, page_increment=0, page_size=0
      ),
      climb_rate=0, digits=1
    )
    self.camera_ratio.set_value(float(self.config["cameraRatio"]))

    camera_capture_device_label = Gtk.Label()
    camera_capture_device_label.set_markup(
      "<small>Video capture device</small>")
    camera_near_label = Gtk.Label()
    camera_near_label.set_markup("<small>Near</small>")
    camera_far_label = Gtk.Label(label="Far")
    camera_far_label.set_markup("<small>Far</small>")
    camera_ratio_label = Gtk.Label(label="Ratio")
    camera_ratio_label.set_markup("<small>Ratio</small>")

    camera_frame_grid.attach(self.camera_capture_device, 0, 1, 1, 1)
    camera_frame_grid.attach(camera_capture_device_label, 0, 0, 1, 1)
    camera_frame_grid.attach(self.camera_near, 1, 1, 1, 1)
    camera_frame_grid.attach(camera_near_label, 1, 0, 1, 1)
    camera_frame_grid.attach(self.camera_far, 2, 1, 1, 1)
    camera_frame_grid.attach(camera_far_label, 2, 0, 1, 1)
    camera_frame_grid.attach(self.camera_ratio, 3, 1, 1, 1)
    camera_frame_grid.attach(camera_ratio_label, 3, 0, 1, 1)

    ########### Face tracking settings ###########
    face_settings = Gtk.Frame(
      label="Face tracking settings", label_xalign=0.05)
    grid.attach_next_to(face_settings, camera_frame,
              Gtk.PositionType.BOTTOM, 1, 1)

    face_settings_grid = Gtk.Grid(column_spacing=5)
    face_settings_grid.set_border_width(5)

    face_settings.add(face_settings_grid)

    self.face_settings_minsize = Gtk.SpinButton(
      adjustment=Gtk.Adjustment(
        value=0, lower=0, upper=100, step_increment=1, page_increment=0, page_size=0
      ),
      climb_rate=0, digits=0
    )
    self.face_settings_minsize.set_value(int(self.config["minFaceSize"]))

    self.face_settings_gap = Gtk.SpinButton(
      adjustment=Gtk.Adjustment(
        value=0, lower=0, upper=100, step_increment=1, page_increment=0, page_size=0
      ),
      climb_rate=0, digits=0
    )
    self.face_settings_gap.set_value(int(self.config["eyesGapInCm"]))

    self.face_settings_pixpercm = Gtk.SpinButton(
      adjustment=Gtk.Adjustment(
        value=0, lower=0, upper=100, step_increment=1, page_increment=0, page_size=0
      ),
      climb_rate=0, digits=0
    )
    self.face_settings_pixpercm.set_value(int(self.config["pixelPerCm"]))

    face_settings_minsize_label = Gtk.Label()
    face_settings_minsize_label.set_markup(
      "<small>Minimum face size</small>")
    face_settings_gap_label = Gtk.Label()
    face_settings_gap_label.set_markup("<small>Eyes gap</small>")
    face_settings_pixpercm_label = Gtk.Label()
    face_settings_pixpercm_label.set_markup("<small>Pixels/Cm</small>")

    face_settings_grid.attach(self.face_settings_minsize, 0, 1, 1, 1)
    face_settings_grid.attach(face_settings_minsize_label, 0, 0, 1, 1)
    face_settings_grid.attach(self.face_settings_gap, 1, 1, 1, 1)
    face_settings_grid.attach(face_settings_gap_label, 1, 0, 1, 1)
    face_settings_grid.attach(self.face_settings_pixpercm, 2, 1, 1, 1)
    face_settings_grid.attach(face_settings_pixpercm_label, 2, 0, 1, 1)

    ########### Advanced settings ###########
    adv_settings = Gtk.Frame(label="Advanced settings", label_xalign=0.05)
    grid.attach_next_to(adv_settings, face_settings,
              Gtk.PositionType.BOTTOM, 1, 1)

    adv_settings_grid = Gtk.Grid(
      column_homogeneous=False, column_spacing=5, row_spacing=5)
    adv_settings_grid.set_border_width(5)

    adv_settings.add(adv_settings_grid)

    self.adv_settings_draw_wireframe = Gtk.Switch(
      state=self.config["drawWireframe"] == "True")
    self.adv_settings_proj_mode = Gtk.Switch(
      state=self.config["projectionMode"] == "True")
    self.adv_settings_lock_axis = Gtk.Switch(
      state=self.config["lockZ"] == "True")

    adv_settings_cascade_path_label = Gtk.Label(label="Face cascade path:")
    self.adv_settings_cascade_path = Gtk.FileChooserButton()
    self.adv_settings_cascade_path.set_filename(self.config["cascadePath"])
    self.adv_settings_cascade_path.set_hexpand(True)

    adv_settings_checkbox_grid = Gtk.Grid(row_spacing=5)
    adv_settings_checkbox_grid.attach(
      Gtk.Label(label="Draw wireframe"), 0, 0, 1, 1)
    adv_settings_checkbox_grid.attach(Gtk.Label(expand=True), 1, 0, 1, 1)
    adv_settings_checkbox_grid.attach(
      self.adv_settings_draw_wireframe, 2, 0, 1, 1)
    adv_settings_checkbox_grid.attach(
      Gtk.Label(label="Projection mode"), 0, 1, 1, 1)
    adv_settings_checkbox_grid.attach(Gtk.Label(expand=True), 1, 1, 1, 1)
    adv_settings_checkbox_grid.attach(
      self.adv_settings_proj_mode, 2, 1, 1, 1)
    adv_settings_checkbox_grid.attach(
      Gtk.Label(label="Lock Z axis", xalign=0.0), 0, 2, 1, 1)
    adv_settings_checkbox_grid.attach(Gtk.Label(expand=True), 1, 2, 1, 1)
    adv_settings_checkbox_grid.attach(
      self.adv_settings_lock_axis, 2, 2, 1, 1)

    adv_settings_grid.attach(adv_settings_checkbox_grid, 0, 0, 2, 3)
    adv_settings_grid.attach(adv_settings_cascade_path_label, 0, 3, 1, 1)
    adv_settings_grid.attach(self.adv_settings_cascade_path, 1, 3, 1, 1)

    ########### Button box ###########
    button_box = Gtk.Box(spacing=5)
    grid.attach_next_to(button_box, adv_settings,
              Gtk.PositionType.BOTTOM, 1, 1)

    reset_button = Gtk.Button.new_with_label("Reset")
    reset_button.connect("clicked", self.resetConfig)
    save_button = Gtk.Button.new_with_label("Save")
    save_button.connect("clicked", self.saveConfig)

    button_box.pack_start(reset_button, True, True, 0)
    button_box.pack_start(save_button, True, True, 0)

  def reinitVars(self):
    self.adv_settings_draw_wireframe.set_active(
      self.config["drawWireframe"] == True)
    self.adv_settings_proj_mode.set_active(
      self.config["projectionMode"] == True)
    self.adv_settings_lock_axis.set_active(self.config["lockZ"] == True)
    self.adv_settings_cascade_path.set_filename(self.config["cascadePath"])

    self.face_settings_minsize.set_value(int(self.config["minFaceSize"]))
    self.face_settings_gap.set_value(int(self.config["eyesGapInCm"]))
    self.face_settings_pixpercm.set_value(int(self.config["pixelPerCm"]))

    self.camera_capture_device.set_value(
      int(self.config["videoCaptureDevice"]))
    self.camera_near.set_value(int(self.config["cameraNear"]))
    self.camera_far.set_value(int(self.config["cameraFar"]))
    self.camera_ratio.set_value(float(self.config["cameraRatio"]))

    self.model_file_chooser.set_filename(self.config["modelPath"])

  def noneFileErrorResponse(self, widget, response_id):
    widget.destroy()

  def noneFileError(self, msg):
    dialog = Gtk.Dialog(
      parent=self,
      modal=True,
      title="Error!"
    )
    dialog.set_border_width(5)
    dialog.set_resizable(False)
    dialog.add_button(button_text="OK", response_id=Gtk.ResponseType.OK)
    dialog.connect("response", self.noneFileErrorResponse)

    contents = Gtk.Box(spacing=5)
    dialog.get_content_area().add(contents)

    contents.pack_start(Gtk.Image.new_from_icon_name(
      "dialog-error", Gtk.IconSize.DIALOG), True, True, 0)
    contents.pack_start(Gtk.Label(label=msg), True, True, 0)

    dialog.show_all()

  def writeConfig(self, config):
    with open("data/config.cfg", "w") as conf:
      for field, item in config.items():
        conf.write(field + "=" + str(item))
        if (field, item) != list(config.items())[-1]:
          conf.write("\n")
    print(config)
    self.reinitVars()

  def readConfig(self, config):
    with open("data/config.cfg", "r") as conf:
      for line in conf:
        item = str(line).replace(" ", "").split('=')
        config[item[0]] = item[1].replace("\n", "")

  def resetConfig(self, reset_button):
    self.config = {
      "modelPath": "data/models/minecraft_1.obj",
      "videoCaptureDevice": 0,
      "cascadePath": "data/haarcascade_frontalface_alt.xml",
      "cameraFar": 100,
      "cameraNear": 1,
      "cameraRatio": 0.3,
      "minFaceSize": 80,
      "f": 500,
      "eyesGapInCm": 7,
      "pixelPerCm": 10,
      "drawWireframe": False,
      "projectionMode": True,
      "lockZ": False
    }
    self.writeConfig(self.config)
    self.reinitVars()

  def saveConfig(self, save_button):
    print("Saving configuration...")
    if (path := self.model_file_chooser.get_filename()) != None:
      if search(r"\w+.obj", str(path)):
        self.config["modelPath"] = path
      else:
        self.noneFileError("Not an .obj file!")
        return
    else:
      self.noneFileError("Model path not found!")
      return

    if (path := self.adv_settings_cascade_path.get_filename()) != None:
      if search(r"\w+.xml", str(path)):
        self.config["cascadePath"] = path
      else:
        self.noneFileError("Not an .xml file!")
        return
    else:
      self.noneFileError("Face cascade path not found!")
      return

    self.config["videoCaptureDevice"] = self.camera_capture_device.get_value_as_int()
    self.config["cameraFar"] = self.camera_far.get_value_as_int()
    self.config["cameraNear"] = self.camera_near.get_value_as_int()
    self.config["cameraRatio"] = self.camera_ratio.get_value()
    self.config["drawWireframe"] = self.adv_settings_draw_wireframe.get_state()
    self.config["projectionMode"] = self.adv_settings_proj_mode.get_state()
    self.config["lockZ"] = self.adv_settings_lock_axis.get_state()
    self.config["f"] = 500
    self.config["minFaceSize"] = self.face_settings_minsize.get_value_as_int()
    self.config["eyesGapInCm"] = self.face_settings_gap.get_value_as_int()
    self.config["pixelPerCm"] = self.face_settings_pixpercm.get_value_as_int()
    self.writeConfig(self.config)


def main():
  win = MainWindow()
  win.connect("destroy", Gtk.main_quit)
  win.show_all()
  Gtk.main()


if __name__ == "__main__":
  main()
